﻿namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Incorrect grade value! Grade must be between 2 and 6!");
                }
                this.grade = value;
            }
        }
    }
}
