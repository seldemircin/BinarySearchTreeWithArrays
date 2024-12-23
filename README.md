# Binary Search Tree with Arrays

This repository demonstrates the implementation of a **Binary Search Tree (BST)** using an array structure in C#. It includes functionality for adding, searching, deleting elements, and printing the tree in an **in-order traversal**. This approach is suitable for educational purposes to understand how binary trees can be implemented using arrays.

---

## Features

- **Add Operation**: Inserts a new value into the BST.
- **Search Operation**: Searches for a specific value in the BST.
- **Delete Operation**: Removes a value from the BST.
  - Handles leaf nodes, nodes with one child, and nodes with two children.
- **Print Operation**: Displays the tree using in-order traversal.

---

## Project Structure

- **`Program.cs`**: Contains the implementation of the Binary Search Tree operations using an array.

---

## How It Works

### Array Representation of a Binary Search Tree
- The array simulates a binary tree, where:
  - Index `0` is the root of the tree.
  - For any node at index `i`:
    - The left child is at index `2 * i + 1`.
    - The right child is at index `2 * i + 2`.

### Example Tree
For the tree:
```
        20
       /  \
     15    30
          /  \
        28    40
       /  \
     27    29
```
The array representation would look like this:
```
[20, 15, 30, 0, 0, 28, 40, 0, 0, 27, 29]
```

---

## How to Use

### Prerequisites
- .NET SDK (6.0 or later)

### Running the Program
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/BinarySearchTreeWithArrays.git
   cd BinarySearchTreeWithArrays
   ```

2. Open the project in your favorite IDE (e.g., Visual Studio, Rider) or use the command line.

3. Build and run the project:
   ```bash
   dotnet run
   ```

### Operations in the Code

#### Adding Elements
The `Add` method recursively places elements in their correct position:
```csharp
Add(20, 0);
Add(15, 0);
Add(30, 0);
Add(28, 0);
Add(40, 0);
Add(27, 0);
Add(29, 0);
Add(35, 0);
Add(50, 0);
```

#### Deleting an Element
The `Delete` method removes a node and maintains the BST structure:
```csharp
Delete(35, 0);
```

#### Searching for an Element
The `Search` method checks whether a specific value exists in the tree:
```csharp
if (Search(35, 0))
{
    Console.WriteLine("Mevcut.");
}
else
{
    Console.WriteLine("Mevcut değil.");
}
```

#### Printing the Tree
The `PrintTree` method displays the tree using in-order traversal:
```csharp
PrintTree(0);
```
Output:
```
15 20 27 28 29 30 40 50
```

---

## Code Example
Here is an example usage of all operations:
```csharp
Add(20, 0);
Add(15, 0);
Add(30, 0);
Add(28, 0);
Add(40, 0);
Add(27, 0);
Add(29, 0);
Add(35, 0);
Add(50, 0);

Delete(35, 0);

PrintTree(0);

if (Search(35, 0))
{
    Console.WriteLine("Mevcut.");
}
else
{
    Console.WriteLine("Mevcut değil.");
}
```

---

## Contributing
Contributions are welcome! If you find any bugs or have suggestions for improvement, feel free to open an issue or submit a pull request.

---

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## Acknowledgments
- Inspired by the need for understanding data structures in a practical, visual manner.

Happy coding!

