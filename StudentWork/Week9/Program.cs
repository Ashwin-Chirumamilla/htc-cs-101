using System;
using System.Collections.Generic;

namespace Week9
{
    
    class Program
    {
        
        static List<string> itemList = new List<string>();
        static List<string> starsList = new List<string>();
        public static void viewList() {
            
            int number = 0;
            Console.WriteLine("List (Items: " + itemList.Count + "):");
            if (itemList.Count == 0) {
                Console.WriteLine("No items added");
            }
            else {
            /*for (int i = 0; i < itemList.Count; i++) {
                Console.WriteLine((i+1) + ". " + itemList[i]);
            }*/
            foreach(string item in itemList) {
                number++;
                if (starsList.Contains(item)) {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(number + ". " + item);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static string addItem() {
            Console.WriteLine("What would you like to add?");
            string addedItem = Console.ReadLine();
            return addedItem;
        }
        public static void getItem(List<string> itemList) {
            Console.WriteLine("Enter the index of the item you would like to retrieve");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(itemList[index]);
        }
        public static void deleteItem() {
            Console.WriteLine("What is the index of the item you would like to delete?");
            int index = Convert.ToInt32(Console.ReadLine());
            itemList.RemoveAt(index);
        }
        public static void reorderItem() {
            viewList();
            for (int i = 0; i < itemList.Count; i++) {
                Console.WriteLine("What is the current index of the item you would like at index " + i);
                int oldIndex = Convert.ToInt32(Console.ReadLine());
                itemList[i] = itemList[oldIndex];
            }
            Console.WriteLine("New List:");
            viewList();
        }
        public static void essentialItems() {
            viewList();
            Console.WriteLine("Enter the name of the item you would like to flag:");
            string starsIndex =Console.ReadLine();
            starsList.Add(starsIndex);
        }
        static void Main(string[] args)
        {
            
            while (true) {
            Console.WriteLine("What would you like to do: ('add', 'view', 'get item', 'delete', 'reorder', 'flag')");
            string action = Console.ReadLine();
                if (action == "add") {
                    string addedItem = addItem();
                    itemList.Add(addedItem);
                }
                else if (action == "view") {
                    
                    viewList();
                }
                else if (action == "get item") {
                    getItem(itemList);
                }
                else if (action == "delete") {
                    deleteItem();
                }
                else if (action == "reorder") {
                    reorderItem();
                }
                else if (action == "flag") {
                    essentialItems();
                }
                else {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
