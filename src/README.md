# 環境構築時のメモ

## プロジェクト作成
Ctrl + Shift + Pを押下し、dotnetのプロジェクト作成

## Testプロジェクト作成
Ctrl + Shift + Pを押下し、dotnetのMSTestプロジェクト作成

## テストプロジェクトをメインのプロジェクトに参照させる

```bash
dotnet add ./ConsoleApp/ConsoleApp.csproj reference ./TestProject/TestProject.csproj 
```

## 拡張機能

C# div kitを利用している