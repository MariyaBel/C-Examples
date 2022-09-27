// Проосмотореть все файлы в директории

// string path ="/Users/dzzzr/Desktop/Geekbrains/3 -Введение в программирование на С#";

// DirectoryInfo di= new DirectoryInfo(path);// программа которая позволяет получить информацию о дате создания и файлах в папке
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i=0;i<fi.Length;i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }


void CatalogInfo(string path, string indent ="")
{
DirectoryInfo catalog = new DirectoryInfo(path);
DirectoryInfo[] catalogs=catalog.GetDirectories();
for (int i =0; i<catalogs.Length;i++)// все файлы в массив
{
    Console.WriteLine($"{indent}{catalogs[i].Name}");// вывод информации о текущем каталоге
    CatalogInfo(catalogs[i].FullName, indent + " ");//рекурсия во все подпапки каталога
}
FileInfo[] files = catalog.GetFiles();// список файлов директории

for (int i=0;i<files.Length;i++)
{
    Console.WriteLine($"{indent}{files[i].Name}");
}
}

string path =@"/Users/dzzzr/Desktop/Geekbrains/3 -Введение в программирование на С#";// ссылка на директорию
CatalogInfo(path);// запуск функции по указанной ссылке