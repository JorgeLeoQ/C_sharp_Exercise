using System;

namespace Exercise5
{
    public class Message
    {
        private string phrase;
        private string story;
        private string firstName;
        private string lastName;
        private string city;

        public Message(string phrase, string story, string firstName, string lastName, string city)
        {
            this.phrase = phrase;
            this.story = story;
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
        }
        public override string ToString()
        {
            return this.phrase+this.story+ "-- "+this.firstName+" "+this.lastName+","+this.city+".";
        }
    }
}
