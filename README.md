# cs-con-form-open-file-dialog
コンソールで System.Windows.Forms を利用

## 参考
[WPF/Windowsフォームに関する.NET 5の大きな変更](https://www.infoq.com/jp/news/2021/02/net-5-breaking-changes-windows/)

```cs
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net5.0-windows</TargetFramework>
    <RootNamespace>cs_con_form_open_file_dialog</RootNamespace>
    <UseWindowsForms>true</UseWindowsForms>
    <DisableWinExeOutputInference>true</DisableWinExeOutputInference>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="System.Text.Encoding.CodePages" Version="5.0.0" />
  </ItemGroup>

</Project>
```
```
<OutputType>Exe</OutputType>
<DisableWinExeOutputInference>true</DisableWinExeOutputInference>
```

```
<TargetFramework>net5.0-windows</TargetFramework>
```
```
<UseWindowsForms>true</UseWindowsForms>
```
