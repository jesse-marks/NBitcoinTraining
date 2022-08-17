# Programming Bitcoin in C#/.NET
Using the book [Programming The Blockchain in C#](https://programmingblockchain.gitbook.io/programmingblockchain/) and
implementing features from the .NET Bitcoin library https://github.com/MetacoSA/NBitcoin

## Development Setup
This is my personal setup.
* [VS Code](https://code.visualstudio.com) to write the code in.
* miniconda to create a virtual environment
* Install .Net Core with conda
```shell
conda install -c conda-forge dotnet
```
* create project
```shell
mkdir NBitcoinTraining
cd NBitcoinTraining
dotnet new console
dotnet add package NBitcoin
dotnet add package NBitcoinTest.Framework

code . //enter VS Code
```








