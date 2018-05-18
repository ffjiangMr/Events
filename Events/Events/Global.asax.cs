using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Events
{
    public class Global : System.Web.HttpApplication
    {

        public Global()
        {
            BeginRequest += this.HandlerEvent;
            EndRequest += this.HandlerEvent;
            AcquireRequestState += this.HandlerEvent;
            PostAcquireRequestState += this.HandlerEvent;
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Application, "Start");
            Application["message"] = "Application Events";
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Application, "BeginRequest");
            Response.Write(String.Format($"Request start at {DateTime.Now.ToLongTimeString()}"));
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Application, "End");

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        protected void HandlerEvent(Object sender, EventArgs e)
        {
            String eventName = "<UnKnow>";
            switch (Context.CurrentNotification)
            {
                case RequestNotification.BeginRequest:
                    break;
                case RequestNotification.EndRequest:
                    break;
                case RequestNotification.AcquireRequestState:
                    break;
                    
            }
        }
    }
}