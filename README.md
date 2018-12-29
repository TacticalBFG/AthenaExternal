# AthenaExternal
Use functions from this if you want to make your own Athena UI. Some functions are required.


Required functions:

Form1.cs -> public Form1()
* Required for proper injection & whitelisting.

AthenaFirstTimeSetup.cs -> public void enterpls_Click(object sender, EventArgs e)
* Required for whitelisting & data folder creation.

Athena's pipe name is called "scriptpipe", the only argument is a string that contains the script you'd want to execute.
(Source example in Form1.cs -> void boye())
