﻿// See https://aka.ms/new-console-template for more information

using SlowFastPointer;

Console.WriteLine("Fast & Slow Pointer");
LinkedListFindCycle findCycle = new LinkedListFindCycle();
Console.WriteLine(findCycle.CycleExist(findCycle.createList()));

LengthOfCycleInCyclicLinkedList lengthOfCyclicLinkedList = new LengthOfCycleInCyclicLinkedList();
Console.WriteLine(lengthOfCyclicLinkedList.CycleLength(lengthOfCyclicLinkedList.create()));