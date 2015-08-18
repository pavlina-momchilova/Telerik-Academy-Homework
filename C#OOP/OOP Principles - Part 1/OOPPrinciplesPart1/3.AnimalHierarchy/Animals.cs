using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    public enum Sex
    {
        male,
        female
    }
    public abstract class Animals: ISound
    {
        #region fields
        private byte age;
        private string name;
        private Sex sex;
        #endregion

        #region constructors
        public Animals(byte age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        #endregion

        #region properties
        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Animal cannot have age less than 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty");
                }
                else if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be null or just a space");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public Sex Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }
        #endregion

        #region methods
        public abstract void produceSound();
        #endregion
    }
}
