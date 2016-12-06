namespace zenithsociety.Migrations.Events
{
    using DataContext;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib;

    internal sealed class Configuration : DbMigrationsConfiguration<zenithsociety.DataContext.EventContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Events";
        }

        protected override void Seed(zenithsociety.DataContext.EventContext context)
        {
            context.Activities.AddOrUpdate(getActivity().ToArray());
            context.SaveChanges();
            context.Events.AddOrUpdate(getEvents(context).ToArray());
            context.SaveChanges();
        }


        private List<Event> getEvents(EventContext db)
        {
            
            List<Event> events = new List<Event>(){
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,09,27,08,30,00),
                   EventToDateAndTime = new DateTime(2016,09,27,10,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   
                   activity = "Seniors Golf Tournament"

               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,09,28,08,30,00),
                   EventToDateAndTime = new DateTime(2016,09,28,10,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity = "Leadership General Assembly Meeting"

                    
                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,09,30,17,30,00),
                   EventToDateAndTime = new DateTime(2016,09,30,19,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity = "Youth Bowling Tournament"
                   
    
                
//activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,09,30,19,00,00),
                   EventToDateAndTime = new DateTime(2016,09,30,20,00,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity ="Young Ladoes Cooking Lessons"


                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,01,08,30,00),
                   EventToDateAndTime = new DateTime(2016,10,01,10,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity ="Youth Craft Lessons"



                
                
                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,01,10,30,00),
                   EventToDateAndTime = new DateTime(2016,10,01,12,00,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity = "Youth Choir Practice"
              
                
                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,01,12,00,00),
                   EventToDateAndTime = new DateTime(2016,10,01,13,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity = "Lunch"

                   
               
                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,02,07,30,00),
                   EventToDateAndTime = new DateTime(2016,10,02,08,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity = "Pancake Breafast"

                    
               
                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,02,08,30,00),
                   EventToDateAndTime = new DateTime(2016,10,02,10,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity  = "Swimming Lessons for the Youth"
                   
               
                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,02,08,30,00),
                   EventToDateAndTime = new DateTime(2016,10,02,10,30,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity  = "Swimming Lessons for the Parents"

             

                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,02,10,30,00),
                   EventToDateAndTime = new DateTime(2016,10,02,12,00,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity = "Bingo Tournament"

                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,02,12,00,00),
                   EventToDateAndTime = new DateTime(2016,10,02,13,00,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity = "BBQ Lunch"


           

                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               },
               new Event()
               {
                   EventFromDateaAndTime = new DateTime(2016,10,02,13,00,00),
                   EventToDateAndTime = new DateTime(2016,10,02,18,00,00),
                   IsActive = false,
                   CreationDate = new DateTime(2016,04,01),
                   activity ="Garage Sale"
                                          
                   //activity = db.Activities.AddOrUpdate(t=>t.ActivityDescrption == "Seniors Golf Tournament"),
                                
               }

            };

            return events;
        }



        private List<Activity> getActivity()
        {
            List<Activity> activities = new List<Activity>
            {
                new Activity() {ActivityDescrption = "Seniors Golf Tournament", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Leadership General Assembly Meeting", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Youth Bowling Tournament", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Young Ladoes Cooking Lessons", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Youth Craft Lessons", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Youth Choir Practice", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Lunch", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Pancake Breafast", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Swimming Lessons for the Youth", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Swimming Lessons for the Parents", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Bingo Tournament", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "BBQ Lunch", CreationDate = new DateTime(2016,04,01) },
                new Activity() {ActivityDescrption = "Garage Sale", CreationDate = new DateTime(2016,04,01) }
            };

            return activities;
        }
    }
}

