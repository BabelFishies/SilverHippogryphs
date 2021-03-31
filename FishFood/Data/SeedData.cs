using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFood.Models;

namespace FishFood.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            SeedGameText(context);
        }
        private static void SeedGameText(ApplicationDbContext context)
        {
            if (!context.GameText.Any())
            {
                context.GameText.Add(new GameText(@"Ah, I love the sand. The beach. The pleasant ocean air blowing through my hair as it brings in all of the sea's subtle scents... Days like this makes one feel like there's not a problem a in the world, and now finally, for me there isn't. After a lifetime of studying, I've finally earned my doctorate, and Amazonia has agreed to buy me... Yeah, it's a pretty sweet deal. Unlimited access to the Amazonia employee city state of New Dakota- a silver level district!- with the opportunity to advance to a Gold or even Platinum level district- and in return they own my name, likeness, and everything I produce. Oh, and I'm required to get a Amazonia Employee Implant, but that's the coolest part! An always-on VR/AR headset? Yes please! Yep... I suspect I'll get the call to get mine in any time now.... Wait... how long have I been at this beach? Shouldn't I have gotten the implant before I got here? Wait....

            Oh, shit. I lift my head out of the sand and start coughing up clouds of the stuff. I hate sand. Okay, I'm passed out in the desert because... I look around. Close behind me, the remains of the airship transporting me to New Dakota lay scattered... Ahead, the lights of a small city protruding above a wall. To my left, the comforting sight of a McDank's Kentucky Boiled Mystery Meat Shack. And to my right... Lasers firing off into the air? And a strange alien creature doing an hypnotic dance. Hmm...
      "));
                context.SaveChanges();
            }

        }
    }
}
