﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Call CreateRedirectionRulesFile() function to create the rules of redirection 
            CreateRedirectionRulesFile();
            //Start server
            // 1) Make server object on port 1000
            Server server = new Server(1000, "redirectionRules.txt");
            // 2) Start Server
            server.StartServer();
        }

        static void CreateRedirectionRulesFile()
        {
            File.WriteAllText("redirectionRules.txt", "aboutus.html,aboutus2.html" + Environment.NewLine +
                "contactus.html,contactus2.html");
        }

    }
}
