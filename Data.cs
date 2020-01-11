using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Data
    {
    }
    public class Team
    {
        public string name;
        public Trainers trainers;
        public Team(string name)
        {
            this.trainers = new Trainers();
            this.name = name;
        }
        public Trainers FindTheLast()
        {
            var trainer = this.trainers;
            bool tak = true;
            while (tak)
            {
                if(trainer.deputy != null)
                {
                    trainer = trainer.deputy;
                } else
                {
                    tak = false;
                }
            }
            return trainer;
        }
        public void Push(string firstname, string surname, int age, string role)
        {
            var newOne = new Trainers(firstname, surname, age, role);
            var trainer = this.FindTheLast();
            newOne.moderator = trainer;
            trainer.deputy = newOne;
        }
    }
    public class Trainers
    {
        public string firstname;
        public string surname;
        public int age;
        public string role;
        public Trainers deputy;
        public Trainers moderator;
        public Trainers() { }
        public Trainers(string firstname, string surname, int age, string role)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.age = age;
            this.role = role;
        }
    }
}
