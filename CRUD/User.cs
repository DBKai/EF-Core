﻿namespace CRUD
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Name} - {Age}";
        }
    }
}
