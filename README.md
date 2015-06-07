AcspNet.MessagePage
===

[AcspNet web-framework](https://github.com/i4004/AcspNet) message page control


## Package status

| Latest version |
| :------ |
| [![Nuget version](http://img.shields.io/badge/nuget-v1-blue.png)](https://www.nuget.org/packages/AcspNet.MessagePage.Sources/) |

## Build status

| Platform | Status of last build |
| :------ | :------: |
| **.NET (4.5)** | [![AppVeyor build status](https://ci.appveyor.com/api/projects/status/p3e0o0r1u83nam23/branch/master?svg=true)](https://ci.appveyor.com/project/i4004/acspnet-messagepage) |
| **Mono (3.8.0)** | [![Travis build status](https://travis-ci.org/i4004/AcspNet.MessagePage.png?branch=master)](https://travis-ci.org/i4004/AcspNet.MessagePage) |

## Usage

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
