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
        public Players players;
        public Others others; 
        public Team(string name)
        {
            this.trainers = new Trainers();
            this.players = new Players();
            this.others = new Others();
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
        public Players FindTheLast2()
        {
            var player = this.players;
            bool tak = true;
            while (tak)
            {
                if (player.deputy != null)
                {
                    player = player.deputy;
                }
                else
                {
                    tak = false;
                }
            }
            return player;
        }
            public void Push2(string firstname, string surname, int age, string role)
        {
            var newOne2 = new Players(firstname, surname, age, role);
            var player = this.FindTheLast2();
            newOne2.moderator = player;
            player.deputy = newOne2;
        }
        public Others FindTheLast3()
        {
            var other = this.others;
            bool tak = true;
            while (tak)
            {
                if (other.deputy != null)
                {
                    other = other.deputy;
                }
                else
                {
                    tak = false;
                }
            }
            return other;
        }
        public void Push3(string firstname, string surname, int age, string role)
        {
            var newOne3 = new Others(firstname, surname, age, role);
            var other = this.FindTheLast3();
            newOne3.moderator = other;
            other.deputy = newOne3;
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

    public class Players
    {
        public string firstname;
        public string surname;
        public int age;
        public string role;
        public Players deputy;
        public Players moderator;
        public Players() { }
        public Players(string firstname, string surname, int age, string role)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.age = age;
            this.role = role;
        }

    }
    public class Others
    {
        public string firstname;
        public string surname;
        public int age;
        public string role;
        public Others deputy;
        public Others moderator;
        public Others() { }
        public Others(string firstname, string surname, int age, string role)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.age = age;
            this.role = role;
        }

    }
}
