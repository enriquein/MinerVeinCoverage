@echo off
echo Building package.
dotnet build -c Release
rmdir /s /q dist
mkdir dist
cp bin\Release\netstandard2.0\MinerVeinCoverage.dll MinerVeinCoverage.dll
"C:\Program Files\7-Zip\7z.exe" a -tzip dist\minerveincoverage.zip manifest.json icon.png README.md MinerVeinCoverage.dll
rm MinerVeinCoverage.dll
echo Done.