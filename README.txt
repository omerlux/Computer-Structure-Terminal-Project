README
CodeWarrior:
main.c - The main source file of the ARM code. The main loop is there, and all the sub functions to control strings, addresses etc.
UART.c - Configuration of the UART module. The only two channels are: sending to PC, receiving from PC.
LCD.c - Configuration of the LCD screen.
dma.c - Configuration of the DMA module, to send and receive files.
BoardSupport.c - Configurations of ports and timers.
mcg.c - Configuration of the cryctal's timer.
I2C.c - NOT IN USE.
arm_cm0.c + sa_mtb.c - general configurations.

Visual Studio:
Form1.cs - All of the terminal GUI code - including port control, timer configurations, etc.