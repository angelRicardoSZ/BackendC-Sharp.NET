// See https://aka.ms/new-console-template for more information
List<string> shoppingList = new List<string>();
shoppingList.Add("Item 1");
shoppingList.Add("Item 2");
shoppingList.Add("Item 3");
shoppingList.Add("Item 1");

for (int i = 0; i < shoppingList.Count; i++)
{ 
    Console.WriteLine(shoppingList[i]);

}

shoppingList.Remove("Item 1");
shoppingList.RemoveAt(1);

for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
        
}

