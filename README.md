# C# Cheat Sheet

C# Codes Cheat Sheet for your quick reference with coding example

## Example 

```pyramid
public class Pyramid
    {
        public static void RepeaterDesc(int layer)
        {
            for (int i = 1; i < layer; i++)
            {
                for (int Number = 1; Number <= layer - i; Number++)
                {
                    Console.Write(Number);
                }
                Console.WriteLine();
            }
        }
}
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
Copyright (c) 2020 Shahrizal Bin Mohd Hanafiah