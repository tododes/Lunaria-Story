using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStageUIGroup : MenuUIGroup, IRemote
{
    [SerializeField] private float minY, maxY;
    [SerializeField] private MenuController menuController;
    [SerializeField] private List<StageButtonUIGroup> stageButtonGroups;
    [SerializeField] private List<IStageSelectionObserver> observers = new List<IStageSelectionObserver>();

    [SerializeField] private StageButtonUIGroup currentGroup;
    [SerializeField] private int minSelectStageGroupIndex, maxSelectStageGroupIndex;
    private int currentIndex;

    public void registerCommandToButton(string buttonName, ICommand command)
    {
        registerCommandToButton(transform.Find(buttonName).GetComponent<CommandButton>(), command);
    }

    public void registerCommandToButton(CommandButton button, ICommand command)
    {
        button.registerCommand(command);
    }

    protected override void InitializeGroup() {
        RectTransform transform = GetComponent<RectTransform>();
        setDisplayBehaviour(new InvisibleOnHideDisplayModifier(new StageGroupSelectionModifier(new DropBehaviour(transform, minY, maxY, 2f), stageButtonGroups), transform));

        registerCommandToButton("Back Button", new UnpauseGameCommand(menuController));
        registerCommandToButton("Left Arrow Button", new IncrementStageGroupIndexCommand(this, -1));
        registerCommandToButton("Right Arrow Button", new IncrementStageGroupIndexCommand(this, 1));

        registerObserver(transform.Find("Left Arrow Button").GetComponent<LeftArrowButton>());
        registerObserver(transform.Find("Right Arrow Button").GetComponent<RightArrowButton>());

        currentIndex = 0;
        notifyAllObservers();
    }

    public void incrementStageGroupIndex(int inc) {
        currentIndex += inc;
        setCurrentGroup(stageButtonGroups[currentIndex]);
        notifyAllObservers();
    }

    private void setCurrentGroup(StageButtonUIGroup group) {
        if (currentGroup)
            currentGroup.hide();

        currentGroup = group;
        currentGroup.display();
    }

    public bool currentIndexReachedMax() {
        return currentIndex >= maxSelectStageGroupIndex;
    }

    public bool currentIndexReachedMin() {
        return currentIndex <= minSelectStageGroupIndex;
    }

    public void registerObserver(IStageSelectionObserver observer) {
        observers.Add(observer);
    }

    private void notifyAllObservers() {
        for (int i = 0; i < observers.Count; i++) {
            observers[i].update(this);
        }
    }
}
