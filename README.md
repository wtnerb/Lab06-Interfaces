# zoo with interfaces
## Overview
This is the same zoo as before, now with the addition of interfaces. In particular, the ISpeak and ISpellcaster interfaces now force some disparate species far apart in the inheritance tree to share behavior.

## Use
This application does not have much practical purpose.

## Architecture
The design of this lab is a class inheritance tree. An outline is in the picture below.
![class inhertance tree picture](Lab06/ZooOutlineInterfaces.png)
As you can see, the base class is imaginary (NotExist in the actual code.) The other classes descend from that one base class. In particular, the important way today's work is different from yesterday's is the addition of interfaces. Dragons, Liches, Vampires, and Ents all have the ability to speak in most mythological references, so they gain the ISpeak interface. This requires all of those classes to contain a string Speak() method. Additionally, in mythology dragons and liches frequently are powerful magic users so they both are given the ISpellcaster interface, requiring that the developer give both classes a string UseMagic method. All of those new methods and interfaces do get tested.

#### Species
list of concrete species classes that can be instantiated
- Dragon
- Ent
- Cerberus
- Devil's Snare
- Hydra
- Lich
- Vampire
- Zombie

## Sources
Wikipedia provided information especially about dates of origin for mythological origin of the species.
Choices made about which mythological source is the origin of Dragon or Zombie or Hydra were sometimes fairly arbitrary and subjective opinions of the developer, not objective fact.