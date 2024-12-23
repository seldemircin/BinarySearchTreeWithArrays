namespace binary_search_tree_array{}

public class Program
{
    public static int[] tree = new int[100];
    public static void Main()
    {
        Add(20, 0);
        Add(15, 0);
        Add(30, 0);
        Add(28, 0);
        Add(40, 0);
        Add(27, 0);
        Add(29, 0);
        Add(35, 0);
        Add(50, 0);
        
        Delete(35,0);
        
        PrintTree(0);

        if (Search(35,0))
        {
            Console.WriteLine("Mevcut.");
        }
        else
        {
            Console.WriteLine("Mevcut değil.");
        }
    }

    public static int Add(int data,int index)
    {

        if (index >= tree.Length)
        {
            Console.WriteLine($"Dizi dolu olduğundan ekleme işlemi yapılamıyor.");
            return index;
        }
        
        if (tree[index] == data)
        {
            Console.WriteLine($"{data} değeri zaten mevcut olduğundan ekleme işlemi yapılamıyor.");
            return index;
        }
        
        if (tree[index] == 0)
        {
            tree[index] = data;
            Console.WriteLine($"{data} değeri {index}. indekse eklendi.");
            return index;
        }
        
        if (tree[index] < data)
        {
            return Add(data, index * 2 + 2);
        }
        
        return Add(data, index * 2 + 1);
        
    }

    public static bool Search(int data,int index)
    {
        
        if (index >= tree.Length || tree[index] == 0)
        {
            return false;
        }
        
        if (tree[index] < data)
        {
            return Search(data, index * 2 + 2);
        }
        
        if (tree[index] > data)
        {
            return Search(data, index * 2 + 1);
        }

        return true;

    }

    public static void Delete(int data, int index)
    {
        
        if ( index >= tree.Length || tree[index] == 0 )
        {
            Console.WriteLine($"Değer bulunamadığından silme işlemi yapılamadı.");
            return;
        }
        
        if (tree[index] == data)
        {
            if (index * 2 + 1 >= tree.Length && index * 2 + 2 >= tree.Length)
            {
                // yaprak düğüm.
                tree[index] = 0;
            }

            else if ( ( index * 2 + 1 >= tree.Length && tree[index * 2 + 2] != 0 ) || ( index * 2 + 2 >= tree.Length && tree[index * 2 + 1] != 0 ) ) 
            {
                // tek çocuğu olan bir düğüm.
                
                if (index * 2 + 1 >= tree.Length && tree[index * 2 + 2] != 0 )
                {
                    // sağ çocuğu olan.
                    tree[index] = tree[index * 2 + 2];
                    tree[index * 2 + 2] = 0;
                }

                if (index * 2 + 2 >= tree.Length && tree[index * 2 + 1] != 0)
                {
                    // sol çocuğu olan.
                    tree[index] = tree[index * 2 + 1];
                    tree[index * 2 + 1] = 0;
                }
            }
            
            else 
            {
                // iki çocuğu olan.
                
                int successorIndex = index * 2 + 2;
                while (successorIndex * 2 + 1 < tree.Length && tree[successorIndex * 2 + 1] != 0)
                {
                    successorIndex = successorIndex * 2 + 1;
                }

                tree[index] = tree[successorIndex];
                tree[successorIndex] = 0;
                
            }
            
            Console.WriteLine($"{data} değeri silindi.");
            return;
            
        }

        if (tree[index] < data)
        {
            Delete(data,index * 2 + 2);
        }
        else
        {
            Delete(data,index * 2 + 1);
        }
        
    }

    public static void PrintTree(int index)
    {
        if (tree[index] == 0)
        {
            return;
        }
        
        PrintTree(index * 2 + 1);
        Console.Write($"{tree[index]} ");
        PrintTree(index * 2 + 2);
        
    }
    
}