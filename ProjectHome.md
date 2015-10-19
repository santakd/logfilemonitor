LogFileMonitor displays the contents of log files in real time.  Written in C#.NET, LogFileMonitor utilizes Windows file system events to listen for changes and displays them in a auto-scrolling text window.

![http://www.phreeze.com/images/LogFileMonitorScreenShot.png](http://www.phreeze.com/images/LogFileMonitorScreenShot.png)

## Features ##

  * Right-click a file and "Open With..." LogFileMonitor to begin monitoring instantly
  * Files are opened with non-exclusive, read-only access to avoid "file in use" errors
  * Pause/Continue monitoring to examine the output
  * Adjust the buffer size to whatever amount of the log file you wish to view
  * Multiple instances of the app can be open at the same time to monitor multiple files

![http://www.phreeze.com/images/LogFilePurger.png](http://www.phreeze.com/images/LogFilePurger.png)

## Features ##
  * Purge all files in folder older than X days
  * Accepts parameters and runs from the command line
  * ReadMe includes example code for cleaning CruiseControl artifact folders

## System Requirements ##

These apps have only been tested on Windows.  Mono developers interested in porting the app are welcome.