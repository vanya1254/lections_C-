                                                        // create string from a to b  a <= b

// string CreateStringNumsAToB(int a, int b)
// {
//     if(a > b) return String.Empty;
//     return $"{a} " + CreateStringNumsAToB(a + 1, b);
// }

// Console.WriteLine(CreateStringNumsAToB(1, 10));

                                                        // create string from a to b  a >= b

// string CreateStringNumsAToB(int a, int b)
// {
//     if(a < b) return String.Empty;
//     return $"{a} " + CreateStringNumsAToB(a - 1, b);
// }

// Console.WriteLine(CreateStringNumsAToB(10, 1));

                                                        //or

// string CreateStringNumsAToB(int a, int b)
// {
//     if(a > b) return String.Empty;
//     return CreateStringNumsAToB(a + 1, b) + $"{a} ";
// }

// Console.WriteLine(CreateStringNumsAToB(1, 10));

                                                        // sum nums from 1 to N

// int SumNumsFrom1ToN(int n)
// {
//     if (n == 1) return n;
//     return n + SumNumsFrom1ToN(n - 1);
// }

// Console.WriteLine(SumNumsFrom1ToN(10));

                                                        // factorial N

// int FactorialRec(int n)
// {
//     if (n == 0) return 1;
//     if (n == 1) return 1;
//     return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10));

                                                        // pow A to N

// int PowRecAToN(int a, int n)
// {
//     // return n == 0 ? 1 : a * PowRecAToN(a, n - 1);
//     if (n == 0) return 1;
//     return a * PowRecAToN(a, n - 1);
// }

// Console.WriteLine(PowRecAToN(2, 10));

                                                        // or

// int PowRecAToNMath(int a, int n)
// {
//     if (n == 0) return 1;
//     if (n % 2 == 0) return PowRecAToNMath(a * a, n / 2);
//     return a * PowRecAToNMath(a, n - 1);
// }

// Console.WriteLine(PowRecAToNMath(2, 10));

                                                        // create possible words from T - letters

// int n = 1;

// void CreateWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }

//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         CreateWords(alphabet, word, length + 1);
//     }
// }

// CreateWords("аисв", new char[4]);

                                                        // parsing directories

// string path = @"D:/Downloads/GB/konspekt_gb/konspekt_1_quart/lections_C#/1_project";

// // DirectoryInfo di = new DirectoryInfo(path);
// // Console.WriteLine(di.CreationTime);
// // FileInfo[] fi = di.GetFiles();

// // for (int i = 0; i < fi.Length; i++)
// // {
// //     Console.WriteLine(fi[i].Name);
// // }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();

//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + "  ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// CatalogInfo(path);

                                                        // rebus pyramid

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();

                                                        // обход древа структур

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                 0    1     2    3    4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }

// InOrderTraversal();