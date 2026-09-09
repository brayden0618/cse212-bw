using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add two items with different priorities
    // Expected Result: The item with the highest priority is returned first
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Add two items with the same priority
    // Expected Result: The item that was added first is returned first
    // Defect(s) Found:
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Bob", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Alice", result);
    }

    [TestMethod]
    // Scenario: Add two items with the same priority.
    // Expected Result: The first item added is returned first.
    // Defect(s) Found:
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Bob", 5);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("Alice", first);
        Assert.AreEqual("Bob", second);
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue
    // Expected Result: An InvalidOperationException is thrown with the message "The queue is empty."
    // Defect(s) Found:
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}