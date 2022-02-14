# C-Sharp-Nes-Emulator
A NES emulator I built in my spare time. Used some external items for DirectX rendering but that's about it
I used visual studio 2017 to make it so that should be good enough to compile it on windows. 
**YOU MUST UNZIP THE 7z PACKAGES FILE TO BE ABLE TO COMPILE THIS CODE!!! IT WAS TOO BIG TO UPLOAD AS A FOLDER**


## A little background 
The NES or Nintendo Entertainment System is Nintendo's response to the videogame crash of the 80s. Though it was not very powerful boasting a _"Powerful"_
2A03 Processor that ran at a whopping ~2Mhz and a massive 2Kb of general purpose RAM. The NES's titles evolved as the console progressed through its generation all
thanks to it's clever design. As stated before, the NES had only 2kb of RAM but thats not exactly true, the NES also had a 32kb window for the game's code, and an 
additional 8kb for graphics. These windows can be filled with ROM (read only memory) or even more RAM. The NES is not smart enough to care. Whats even better, is that
the NES cartridge can carry more than the 32kb of code and 8kb of graphics, it just needs to switch out code and graphics in chunks. This swapping is achieved with a
microcontroller located on the cartridge connecting both the ROM and RAM chips called the **MAPPER** 

## Specifications

Controls:
- A --> A
- S --> B
- Enter --> Start
- Space --> Select
- Right-Click in the window to access extra functions like
- Pause
- ScreenShot
- Renderer Change
- And Filtering

**This Program Can Render DirectX/OpenGL depending on which your system supports. (Software renderer is included but not recomended because it is TOO SLOW)**

## TESTED TITLES
- Tetris
- Castlevania
- Super Mario Bros.
- The Legend of Zelda(Thought this one had control issues but it turns out im just an idiot and dont know how to use the _Select_ button lol (￣﹃￣)

## Mappers
A certain Few Mappers have been used in this program:
- [NROM](http://bootgod.dyndns.org:7777/search.php?ines=0)
- [MMC1](http://bootgod.dyndns.org:7777/search.php?ines=1)
- [*Senjou no Ookami*](http://bootgod.dyndns.org:7777/search.php?ines=94)
- [Jaleco](http://bootgod.dyndns.org:7777/search.php?ines=140)
- [MMC1A](http://bootgod.dyndns.org:7777/search.php?ines=155)
- [*Crazy Climber*](http://bootgod.dyndns.org:7777/search.php?ines=180)
- [DxROM](http://bootgod.dyndns.org:7777/search.php?ines=206)
- [MMC2](http://bootgod.dyndns.org:7777/search.php?ines=9)
- [MMC4](http://bootgod.dyndns.org:7777/search.php?ines=10)
- [Color Dreams](http://bootgod.dyndns.org:7777/search.php?ines=11)
- [GxROM](http://bootgod.dyndns.org:7777/search.php?ines=66)
- [UxROM](http://bootgod.dyndns.org:7777/search.php?ines=2)
- [CNROM](http://bootgod.dyndns.org:7777/search.php?ines=3)
- [MMC3](http://bootgod.dyndns.org:7777/search.php?ines=4)
- [AxROM](http://bootgod.dyndns.org:7777/search.php?ines=7)
- [Camerica](http://bootgod.dyndns.org:7777/search.php?ines=71)
- [NINA-003-006](http://bootgod.dyndns.org:7777/search.php?ines=79)




