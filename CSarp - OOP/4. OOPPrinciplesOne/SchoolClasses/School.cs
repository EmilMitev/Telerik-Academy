﻿namespace SchoolClasses
{
    using System.Collections.Generic;

    internal class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.classes = classes;
        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }

            set
            {
                this.classes = value;
            }
        }
    }
}
