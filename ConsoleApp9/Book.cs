﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Book : Printable
    {
        string Author;
        string Name;
        string Release;
        public Book(string Name, string Author, string Release)
        {
            this.Name = Name;
            this.Author = Author;
            this.Release = Release;
        }

        public void print()
        {
            Console.WriteLine($"Название книги: {Name}, Автор книги: {Author}, Год выпуска: {Release}");
        }
        public static void printBooks(Printable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Magazine)
                {
                    printable[i].print();
                }
            }
        }
    }
}