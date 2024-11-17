using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple elements with different priorities.
    // Expected Result: Elements are dequeued in the order of highest priority first.
    // Defect(s) Found: None if the priority queue behaves as expected.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Charlie", 3);

        Assert.AreEqual("Alice", priorityQueue.Dequeue());
        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: Exception is thrown indicating the queue is empty.
    // Defect(s) Found: None if the queue throws the correct exception.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Peek at the highest priority element without removing it.
    // Expected Result: The element with the highest priority should be returned, 
    // but not removed from the queue.
    // Defect(s) Found: None if peek works as expected.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Charlie", 3);

        var peeked = priorityQueue.Peek();

        Assert.AreEqual("Alice", peeked);
        Assert.AreEqual(3, priorityQueue.Count);
    }

    [TestMethod]
    // Scenario: Check if the queue is empty after enqueuing and dequeuing elements.
    // Expected Result: The queue should correctly report whether it is empty.
    // Defect(s) Found: None if the isEmpty method works as expected.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Alice", 5);

        var isEmptyBeforeDequeue = priorityQueue.IsEmpty();
        priorityQueue.Dequeue();
        var isEmptyAfterDequeue = priorityQueue.IsEmpty();
        priorityQueue.Dequeue();
        var isEmptyAfterSecondDequeue = priorityQueue.IsEmpty();

        Assert.IsFalse(isEmptyBeforeDequeue);
        Assert.IsFalse(isEmptyAfterDequeue);
        Assert.IsTrue(isEmptyAfterSecondDequeue);
    }
}
