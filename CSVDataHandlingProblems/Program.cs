namespace CSVDataHandlingProblems;
using System;
using CSVStudentApp;
using CSVEmployeeApp;
using CSVCountApp;
using RowFilterApp;
using SearchApp;
using UpdateApp;
using SortApp;
using ValidationApp;
using DataToObjects;
using MergingFiles;
using LargeCSVReader;
using DetectDuplicates;
using JSONtoCSVConvertor;
using EncryptDecrypt;


public class Program
{
    static void Main(string[] args)
    {
        JsonMain.Execute();
        // EncryptDecrypt.EmployeeMain.Execute();
        // DuplicateMain.Execute();
        // CSVReaderMain.Execute();
        // MergeMain.Execute();
        // StudentsMain.Execute();
        // ValidationMain.Execute();
        // SortMain.Execute();
        // UpdateMain.Execute();
        // SearchMain.Execute();
        // FilterRowMain.Execute();
        // CountMain.Execute();
        // EmployeeMain.Start();
        // StudentMain.Start();
    }
}

