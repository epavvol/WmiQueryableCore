# WmiQueryable

***IQueryable Interface Implementation for Windows Management Instrumentation.***
> ## Projects descriptions 
>
>> #### VNetDev.WmiQueryableCore
>> *The project represents main WMI Queryable library that provides base WMI context object, attributes, exception classes and interfaces.*
>
>> #### VNetDev.WmiQueryableCore.WqlTranslator
>> *The projects provide WMI translation functionality.*
>
>> #### VNetDev.WmiQueryableCore.WqlTranslator.Abstraction
>> *This project contains a set of interfaces represent WqlTranslator object and its elements.*
>
>> #### VNetDev.WmiQueryableCore.Cim
>> *The WMI Queryable driver provides communication over WinRM protocol.*
>
>> #### VNetDev.WmiQueryableCore.CIMv2
>> *The project that extends Base WMI context class by implementing all the classes provided in Windows default WMI namespace "root\CIMV2".*

***

> ## Code Examples
>
>> ### Connecting to WMI (Locally with current credentials)
>>```CSharp
>>  var context = new CIMv2WmiContext();
>>  context.Configure(x => x.UseCim());
>>```
>
>> ### Connecting to WMI (Remotely with provided credentials)
>>```CSharp
>>  var context = new CIMv2WmiContext();
>>  context.Configure(x => x.UseCim(
>>      "RemoteComputerNameOrIp", "root\\CIMV2",
>>      PasswordAuthenticationMechanism.Default,
>>      "domain.local", "AdminUserName", "Password123"));
>>```
>
>> ### Adding WmiContext to dependency injection container
>>```CSharp
>>  services.AddWmiContext<WmiContext>(options 
>>      => options.UseCim());
>>```
>
>>### Simple processes query
>>```CSharp
>>	foreach (var process in context.Win32Process
>>      .Where(p => p.Name.StartsWith("calc")))
>>  {
>>      Console.WriteLine($"Found '{process.Name}' process[{process.ProcessId}]! Terminating...");
>>      process.Terminate();
>>  }
>>```
>
>>### Query all devices that have issues
>>```CSharp
>>  foreach (var entity in context.Win32PnPEntity
>>      .Where(e => e.ConfigManagerErrorCode != 0))
>>  {
>>      Console.WriteLine($"Device {entity.Name} has an issue.");
>>  }
>>```
>
>>### New process creation (using static method)
>>```CSharp 
>>  Win32Process.Create(context, "calc.exe");
>>```
>
>>### Custom class and custom Context
>>
>>>#### Class
>>>```CSharp
>>>  [WmiClass(Name = "Win32_Process")]
>>>  public class Win32CustomProcess
>>>  {
>>>      [WmiProperty(Name = "ProcessID")]
>>>      public uint Pid { get; set; }
>>>      public string Name { get; set; }
>>>  }
>>>```
>>
>>>#### Context
>>>```CSharp
>>>  public class CustomWmiContext : WmiContext
>>>  {
>>>      public WmiClassSet<Win32CustomProcess> Processes { get; set; }
>>>
>>>      public CustomWmiContext()
>>>      {
>>>      }
>>>      public CustomWmiContext(WmiContextOptions options) : base(options)
>>>      {
>>>      }
>>>  }
>>>```
>

