## Revision History ##

### Unreleased (Source Only) ###

Unreleased code is available by downloading the source and compiling.  Visual Studio 2008 is required.

Currently the unreleased code has a Local/Network toggle that allows files to be monitored that are on non-windows network shares.  In this case, the filesystem does not notify windows when a change has occured and so LogFileMonitor needs to be constantly refreshed manually.  In the new Network mode, LogFileMonitor uses a timer to re-read the file manually every second.  This has some overhead of re-reading the file.

### Version 0.01 ###

Initial working release