### Resources that I studied:<br>
- [Working with Files in C# 10 - Pluralsight](https://www.pluralsight.com/courses/c-sharp-10-working-files)
- [Getting Started with JSON in C# Using Json.NET 12 - Pluralsight](https://www.pluralsight.com/courses/getting-started-json-csharp-jsondotnet)

# Working with Files in C# 10 - Pluralsight
## Module 2 : Managing Files and Directories

- ` File.Exists()`
- `Directory.Exists()`
- `Directory.CreateDirectory()`
- `File.Copy()`
- `File.Move() `
- `Directory.Delete()`
- `Directory.GetFiles()`
- `Path.Combine()`
- `Path.GetExtension()`
- `Path.ChangeExtension()`

## Module 3: Monitoring the File System for Changes
#### buffer size property:
- Each operation with FileSystemWatcher needs [16 byte + File name]
- Buffer size range is [4 KB --> 64 KB] 
- Default is  8 KB
- It is recommended using mutliple of 4 KB in Intel based CPU




"If there are many changes in a short time, the buffer can overflow. This causes the component to lose track of changes in the directory, and it will only provide blanket notification." [Microsoft documantation](https://learn.microsoft.com/en-us/dotnet/api/system.io.filesystemwatcher.error?view=net-8.0) 


## Module 4 : Reading and Writing Entire Files Into Memory

- `File.ReadAllText()`
- `File.WriteAllText()`
- `File.ReadAllLines()`
- `File.WriteAllLines()`
- `File.AppendAllText() `
- `File.ReadAllBytes()`
- `File.WriteAllBytes()`

<br>

## Module 5: Reading and Writing Data Incrementally Using Streams
Streams benefits

1. **Efficient Memory Usage**
2. **Asynchronous Processing**
3. **Abstraction from backing store**
4. **Seekability**
5. **Performance**: By using streams, you can perform read and write operations in a buffered manner, which can significantly improve the performance of your application. This is because buffered operations reduce the number of I/O operations, which are typically slow.

   
Notes:
- you can specify `Encoding` in `StreamReader` and `StreamWriter`.
- you can append data to `StreamWriter` using a constructor parameter.
- you can randomly access bytes of the Streams.
- you can use memory as a backing store using `MemoryStream`.


# Getting Started with JSON in C# Using Json.NET 12 - Pluralsight
## Module 2 : The case for Json and Json.NET
![Screenshot 2025-01-26 205049](https://github.com/user-attachments/assets/7ea305ff-a553-47e5-b0d1-714bcad8a216)
![image](https://github.com/user-attachments/assets/10001703-12be-45d3-a6be-1200e63d6a90)
## Module 3 : Serialization fundamentals
#### Date Formating Serlizer:
- IsoDateTimeConverter (Default) :
![image](https://github.com/user-attachments/assets/529359bf-4865-4b5b-8b19-d669ea185d9f)

- MicrosoftDateFormat:
![image](https://github.com/user-attachments/assets/2e8d508e-b76e-4ed7-aefd-7b2061b230ff)

- Custom Date Formate:
 ![image](https://github.com/user-attachments/assets/7c479dc4-1b4f-470a-9084-3afa7e8d3677)
![image](https://github.com/user-attachments/assets/48289a5c-11e1-49ab-b9d3-9900dbff1b78)


- Javascript Date Format:
![image](https://github.com/user-attachments/assets/ff54f7e4-3e85-455d-a7c7-7101b4e60fd9)

- Unix datetime Format:
![image](https://github.com/user-attachments/assets/94f3ae9a-85f4-49bc-a6c4-f6507dd8aa39)
![image](https://github.com/user-attachments/assets/7b845ba4-7944-49d8-93ee-9ebba2682e59)


delegate to be called in case of error:
![image](https://github.com/user-attachments/assets/fd0e1dc1-268c-491e-a17f-911a45f3ae7a)
![image](https://github.com/user-attachments/assets/3044d183-3393-4a23-9fe8-73ca74083ba8)

## Module 3 : Settings and attributes

![image](https://github.com/user-attachments/assets/9abc3974-607b-40be-acda-41eba6b4f609)
![image](https://github.com/user-attachments/assets/69e82556-d384-43f9-9ad3-f957b0391e1c)

### Settings:

![image](https://github.com/user-attachments/assets/1f4db74e-d360-4c67-baa8-7ea45ae13a3a)

![image](https://github.com/user-attachments/assets/a1394fa7-132b-444a-b47e-d7175dbf0018)

![image](https://github.com/user-attachments/assets/955de423-a389-4ebf-be35-5432a63bf70f)

![image](https://github.com/user-attachments/assets/b2f494df-1203-47bd-993f-204699abb2e1)
