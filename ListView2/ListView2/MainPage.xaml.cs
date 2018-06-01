using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using ListView2.Models;


namespace ListView2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            myListView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("C", "C")
                {
                    new Contact {Name="Caroline", ImageUrl= "https://placeimg.com/100/100/people/5", Status="am i alive?"}
                },
                new ContactGroup("D", "D")
                {
                    new Contact {Name="Denise", ImageUrl= "https://placeimg.com/100/100/people/4", Status="resentful"}
                },
                new ContactGroup("J", "J")
                {
                    new Contact {Name="Jaime", ImageUrl= "https://placeimg.com/100/100/tech/any", Status="sure!"}
                },
                new ContactGroup("S", "S")
                {
                    new Contact {Name="Steph", ImageUrl= "https://placeimg.com/100/100/people/2", Status="not sure..."},
                    new Contact {Name="Sophie", ImageUrl= "https://placeimg.com/100/100/people/3", Status="so happy"}
                }
            };      

            /*
            myListView.ItemsSource = new List<Contact>
            {
                //new Contact {Name="Jaime", ImageUrl= "http://lorempixel.com/100/100/people/1", Status="sure!"},
                new Contact {Name="Jaime", ImageUrl= "https://placeimg.com/100/100/tech/any", Status="sure!"},
                new Contact {Name="Steph", ImageUrl= "https://placeimg.com/100/100/people/2", Status="not sure..."},
                new Contact {Name="Sophie", ImageUrl= "https://placeimg.com/100/100/people/3", Status="so happy"},
                new Contact {Name="Denise", ImageUrl= "https://placeimg.com/100/100/people/4", Status="resentful"},
                new Contact {Name="Caroline", ImageUrl= "https://placeimg.com/100/100/people/5", Status="am i alive?"}
            }; */
            
        }
	}
}
