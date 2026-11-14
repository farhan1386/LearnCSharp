using System;
using System.Collections.Generic;

namespace Phase_3_Advanced.Week_4_Advanced_Data_Structures_Language_Features
{
    public class Queue_and_Stack
    {
        public static void Run()
        {
            // ==========================================
            // 1. QUEUE: FIFO (First-In, First-Out)
            // Real Scenario: Printer Job Queue
            // ==========================================
            Console.WriteLine("--- Queue Demo (FIFO) ---");
            Queue<string> printerQueue = new Queue<string>();

            // Enqueue: Adds items to the back of the queue
            printerQueue.Enqueue("Invoice.pdf");
            printerQueue.Enqueue("Report.docx");
            printerQueue.Enqueue("Photo.png");

            // Dequeue: Removes and returns the item at the front
            while (printerQueue.Count > 0)
            {
                string currentJob = printerQueue.Dequeue();
                Console.WriteLine($"Printing: {currentJob}");
            }


            // ==========================================
            // 2. STACK: LIFO (Last-In, First-Out)
            // Real Scenario: Text Editor Undo History
            // ==========================================
            Console.WriteLine("\n--- Stack Demo (LIFO) ---");
            Stack<string> undoStack = new Stack<string>();

            // Push: Adds items to the top of the stack
            undoStack.Push("Typed 'Hello'");
            undoStack.Push("Typed 'World'");
            undoStack.Push("Deleted character 'd'");

            // Pop: Removes and returns the item at the top
            while (undoStack.Count > 0)
            {
                string lastAction = undoStack.Pop();
                Console.WriteLine($"Undoing action: {lastAction}");
            }
        }
    }
}