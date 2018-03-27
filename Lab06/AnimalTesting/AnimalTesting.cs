using System;
using Xunit;
using Lab06;

namespace AnimalTesting
{

    public class UnitTest1
    {
        [Fact]
        public void CanMakeTheCount()
        {
            Vampire dracula = new Vampire("Vlad");
            Assert.Equal("Blood", dracula.Sustenance());
            Assert.True(dracula.Base == "Human");
            Assert.False(dracula.Exists);
            Assert.Equal("I vant to drink your blood", dracula.Speak());
        }

        [Fact]
        public void CanMakeSmaug()
        {
            Dragon smaug = new Dragon();
            Assert.Equal(1, smaug.Heads);
            Assert.Equal("Fly", smaug.Locomotion());
            Assert.False(smaug.Exists);
            Assert.Equal("Crispify that!", smaug.BreathFire());
            Assert.Equal("I am a dragon. Fear my teeth, claws, fire and cunning", smaug.Speak());
            Assert.Equal("You are feeling very sleepy. Sleep, mortal, and never awaken.", smaug.UseMagic());
        }

        [Fact]
        public void CanMakeTreeBeard()
        {
            Ent treebeard = new Ent();
            Assert.Equal("Sunlight", treebeard.Sustenance());
            Assert.Equal("Lord of the Rings: The Two Towers (1954) by J.R.R. Tolkien", treebeard.Source());
            Assert.Equal("Where have all the Entwives gone?", treebeard.Speak());
        }

        [Fact]
        public void CanMakeFluffy()
        {
            Cerberus fluffy = new Cerberus();
            Assert.Equal(3, fluffy.Heads);
            Assert.Equal("Run", fluffy.Locomotion());
            Assert.Equal("Theogony (circa 700 BCE) by Hesiod", fluffy.Source());
            Assert.False(fluffy.Exists);
        }

        [Fact]
        public void CanMakeEnsare()
        {
            DevilsSnare constrictor = new DevilsSnare();
            Assert.Equal("Animal flesh", constrictor.Sustenance());
            Assert.Equal("Harry Potter and the Philosopher's Stone (1997) by J. K. Rowling", constrictor.Source());
        }

        [Fact]
        public void CanMakeXykon()
        {
            Lich xykon = new Lich("Xykon");
            Assert.Equal("Xykon", xykon.Name);
            Assert.Equal("Death is an obstacle. Fail to overcome it and face oblivion.", xykon.Speak());
            Assert.Equal("Avada Kedavra", xykon.UseMagic());
            Assert.Equal("null", xykon.Sustenance());
        }

        [Fact]
        public void CanMakeHydra()
        {
            Hydra hydra = new Hydra();
            Assert.Equal("Two grow back!", hydra.CutOffHead("sword"));
            Assert.Equal("Clever adventurer, the hydra now has 9 heads remaining", hydra.CutOffHead("fire"));
            Assert.Equal("Clever adventurer, the hydra now has 8 heads remaining", hydra.CutOffHead("Fire"));
            for (byte i = 8; i > 1; i--)
            {
                hydra.CutOffHead("Fire");
            }
            Assert.Equal("Victory, the hydra is slain!", hydra.CutOffHead("Fire"));
            Assert.Equal("Theogony (circa 700 BCE) by Hesiod", hydra.Source());
            Assert.Equal("Whatever it wants, really", hydra.Sustenance());
            Assert.Equal("Swim/Run", hydra.Locomotion());
        }
    }
}