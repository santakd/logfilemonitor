LogFileSuite
------------

Collection of utility apps for working with logfiles

LogFilePurger:
--------------

Purges all files in a folder older than X days.  This was written to keep log folders
from growing too large, specifically cruise control artifact folders.

Command Line Parameters:

    param1 = [optional] Path to Directory
    param2 = [optional default = 30] Number of Days
    
    Example:
    
    LogFilePurger.exe "c:\logs" 90

    When param1 is provided, the UI will not appear and the app will immediately 
    clean the folder with no prompts.  If there is an error, it will be written to
    a logfile within the same directoy as the executable


Cruise Control Project Example:

	<project>
		<name>Clean Logs</name>
		<triggers>
			<!-- run once per day.  ForceBuild is required if there is no source code change -->
			<intervalTrigger seconds="86400" buildCondition="ForceBuild" />
		</triggers>
		<tasks>
			<exec>
				<executable>C:\Path\To\LogFilePurger.exe</executable>
				<!-- specify the folder path (with quotes if necessary) and number of days to keep files -->
				<buildArgs>"C:\Program Files\CruiseControl.NET\server\My Project\Artifacts\buildlogs" 90</buildArgs>
			</exec>
		</tasks>
	</project>


LogMonitor:
-----------

Allows you to monitor logfiles in realtime.

    param1 = [optional] path to logfile
    
    example:
    
    LogMonitor.exe "c:\logs\myfile.log"

    When param1 is provided, the UI will open and instantly start 
    monitoring the specified file

Credits
-------

Author Jason Hinkle <www.verysimple.com>
Copyright 2008
