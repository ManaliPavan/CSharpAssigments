/*
Create ArrayList of T20 Players. 

Create a class Player (playerid,Name,Country,team)
e.g.   (1,”MSDhoni”,”India”,”Chennai Super Kings”)
Then find out which team has maximum Australian players.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Player
    {
        int playerid;
        string name, country, team;
        
        public Player(int playerid, string name, string country, string team)
        {
            this.Playerid = playerid;
            this.Name = name;
            this.Country = country;
            this.Team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        public override string ToString()
        { 
            return $"PlayerID {Playerid} PlayerName {Name} Country {Country}Team {Team}" ;
        }
        

    }
    class IPL
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Player(1, "Dhoni", "India", "CSK"));
            al.Add(new Player(2, "Conway", "Australia", "CSK"));
            al.Add(new Player(3, "Rohit", "India", "MI"));
            al.Add(new Player(4, "Bravo", "Australia", "CSK"));
            al.Add(new Player(5, "Hardhik", "India", "GT"));
            al.Add(new Player(6, "David", "Australia", "GT"));
            al.Add(new Player(7, "Virat", "India", "RCB"));
            al.Add(new Player(8, "Fab Duplessy", "Australia", "RCB"));

            string max_teamname="";
            int max_count = 0;
            foreach(Player p in al)
            {
                string team = p.Team;
                int c = 0;
                foreach(Player pp in al)
                {
                   if ((pp.Team==(string)team) && (pp.Country == "Australia"))
                        c++;
                }
                if(max_count<c)
                {
                    max_teamname = p.Team;
                    max_count = c;
                }
            }
            Console.WriteLine($"Maximum Australian players are in {max_teamname}={max_count}");
        }
    }
}
