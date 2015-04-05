.NET (4.5) [![Build status](https://ci.appveyor.com/api/projects/status/p3e0o0r1u83nam23/branch/master)](https://ci.appveyor.com/project/i4004/acspnet-messagepage/branch/master)
Mono (3.8.0) [![Travis build status](https://travis-ci.org/i4004/AcspNet.MessagePage.png?branch=master)](https://travis-ci.org/i4004/AcspNet.MessagePage)
[![Nuget version](http://img.shields.io/badge/nuget-v1-blue.png)](https://www.nuget.org/packages/AcspNet.MessagePage.Sources/)

---

AcspNet.MessagePage
===================

[AcspNet web-framework](https://github.com/i4004/AcspNet) message page control

## Usage

Available at NuGet as [source package](https://www.nuget.org/packages/AcspNet.MessagePage.Sources/)

```csharp
	public class MyController : Controller
	{
		public override ControllerResponse Invoke()
		{
            // User will be redirected to message page controller on '/message' and message will be displayed with MessageBox class
			return new RedirectToMessagePage("Some message");
		}
	}
```
