http://msdn.microsoft.com/en-us/library/aa967729%28v=vs.110%29.aspx

To install Message Queuing 4.0 on Windows Server 2008 or Windows Server 2008 R2

    In Server Manager, click Features.

    In the right-hand pane under Features Summary, click Add Features.

    In the resulting window, expand Message Queuing.

    Expand Message Queuing Services.

    Click Directory Services Integration (for computers joined to a Domain), then click HTTP Support.

    Click Next,then click Install.

To install Message Queuing 4.0 on Windows 7 or Windows Vista

    Open Control Panel.

    Click Programs and then, under Programs and Features, click Turn Windows Features on and off.

    Expand Microsoft Message Queue (MSMQ) Server, expand Microsoft Message Queue (MSMQ) Server Core, and then select the check boxes for the following Message Queuing features to install:

        MSMQ Active Directory Domain Services Integration (for computers joined to a Domain).

        MSMQ HTTP Support.

    Click OK.

    If you are prompted to restart the computer, click OK to complete the installation.

To install Message Queuing 3.0 on Windows XP and Windows Server 2003

    Open Control Panel.

    Click Add Remove Programs and then click Add Windows Components.

    Select Message Queuing and click Details.
    Note Note

    If you are running Windows Server 2003, select Application Server to access Message Queuing.

    Ensure that the option MSMQ HTTP Support is selected on the details page.

    Click OK to exit the details page, and then click Next. Complete the installation.

    If you are prompted to restart the computer, click OK to complete the installation.

