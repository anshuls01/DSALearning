// See https://aka.ms/new-console-template for more information

using SlowFastPointer;

Console.WriteLine("Fast & Slow Pointer");
// LinkedListFindCycle findCycle = new LinkedListFindCycle();
// Console.WriteLine(findCycle.CycleExist(findCycle.createList()));
//
// LengthOfCycleInCyclicLinkedList lengthOfCyclicLinkedList = new LengthOfCycleInCyclicLinkedList();
// Console.WriteLine(lengthOfCyclicLinkedList.CycleLength(lengthOfCyclicLinkedList.create()));

// StartOfCycle startOfCycle = new StartOfCycle();
// Console.WriteLine(startOfCycle.findCycleStart(startOfCycle.createList()).Val);

// HappyNumber happyNumber = new HappyNumber();
// Console.WriteLine(happyNumber.isHappyNumber(12));
// Console.WriteLine(happyNumber.isHappyNumber_v1(12));
// Console.WriteLine(happyNumber.isHappyNumber(23));
// Console.WriteLine(happyNumber.isHappyNumber_v1(23));

ReArrangeLinkedList reArrangeLinkedList = new ReArrangeLinkedList();
ListNode head = reArrangeLinkedList.rearrangeList(reArrangeLinkedList.createList());
while (head != null)
{
        Console.WriteLine(head.Val);
        head = head.Next;
}