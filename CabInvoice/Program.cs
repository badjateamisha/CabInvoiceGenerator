﻿// See https://aka.ms/new-console-template for more information
using CabInvoice;

Console.WriteLine("Welcome to Cab Invoice Generator!");
InvoiceGenerator uc1 = new();
double fare1 = uc1.CalculateFare(10, 30);
Console.WriteLine("Total Fare for the Journey is :" + fare1);