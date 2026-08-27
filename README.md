# 🎮 FiveM Settings App

> Professional FiveM Game Settings Manager with Dark Theme UI

![Version](https://img.shields.io/badge/version-1.1-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Platform](https://img.shields.io/badge/platform-Windows-brightgreen)

## ✨ Features

- 🎯 **System Overview Dashboard** - Real-time CPU, RAM, Disk, and Ping monitoring
- 🔊 **Advanced Audio Settings** - Master volume, game volume, voice chat controls with device selection
- ⚡ **Power Plan Tweaks** - Optimize system performance for gaming
- 🎮 **FiveM Launcher Settings** - Dedicated FiveM configuration panel
- 🌙 **Dark Theme UI** - Modern, eye-friendly dark interface
- 🖥️ **System Information** - Network and motherboard monitoring
- ⚙️ **Quick Actions** - One-click system optimization

## 🛠️ Requirements

- **Windows 10/11** (x64)
- **.NET 6.0 Desktop Runtime**
- **Visual Studio 2022** (for development)

## 📥 Installation

### Option 1: Download Pre-built EXE
Download the latest release from [Releases](https://github.com/tonykungcore-sys/FiveM-Settings-App/releases)

```bash
# Simply run the EXE file
FiveM-Settings-App.exe
```

### Option 2: Build from Source

1. **Clone Repository**
```bash
git clone https://github.com/tonykungcore-sys/FiveM-Settings-App.git
cd FiveM-Settings-App
```

2. **Build with Visual Studio**
```bash
# Open the solution
start FiveM-Settings-App.sln

# Or build via command line
dotnet build --configuration Release
```

3. **Build with Command Line**
```bash
dotnet publish -c Release -r win-x64 --self-contained
```

4. **Run Application**
```bash
dotnet run
# Or execute the built EXE
./bin/Release/net6.0-windows/FiveM-Settings-App.exe
```

## 🎯 Usage

### Dashboard
- Monitor real-time system performance
- View CPU, RAM, Disk usage and network ping
- Access quick optimization actions

### Audio Settings
- Control Master, Game, and Voice Chat volumes
- Select output devices and microphone
- Enable audio enhancements (Spatial Audio, Noise Suppression)
- Test audio output and microphone

### FiveM Settings
- Apply power plan tweaks for gaming
- Optimize CPU and minimize latency
- Disable power throttling and hibernation

### System Settings
- Network configuration
- Motherboard information
- Graphics optimization

## 📁 Project Structure

```
FiveM-Settings-App/
├── App.xaml                          # Application resources & theming
├── App.xaml.cs                       # Application entry point
├── MainWindow.xaml                   # Main UI layout
├── MainWindow.xaml.cs                # Main window logic
├── FiveM-Settings-App.csproj         # Project configuration
├── Views/
│   ├── DashboardView.xaml            # System overview UI
│   ├── DashboardView.xaml.cs         # System monitoring logic
│   ├── AudioSettingsView.xaml        # Audio settings UI
│   ├── AudioSettingsView.xaml.cs     # Audio control logic
│   ├── FiveMLauncherView.xaml        # FiveM settings UI
│   └── FiveMLauncherView.xaml.cs     # FiveM settings logic
├── Resources/                         # Images and assets
├── README.md                         # Documentation
└── .gitignore                        # Git ignore rules
```

## 🎨 UI Components

### Dark Theme Colors
- **Background**: `#1a1a1a`
- **Sidebar**: `#0f0f0f`
- **Cards**: `#2a2a2a`
- **Accent**: `#00d4ff` (Cyan)
- **Text**: `#ffffff` (White)

### Responsive Layout
- Sidebar navigation menu
- Content panel with smooth transitions
- Card-based UI components
- Slider controls for volume adjustment

## 🔊 Audio Features

- **Master Volume Control** - Adjust overall system volume
- **Game Volume** - Dedicated gaming audio slider
- **Voice Chat Volume** - Communication volume control
- **Microphone Management** - Device selection and gain control
- **Audio Enhancements**:
  - Spatial Audio
  - Voice Modulation
  - Noise Suppression
  - Echo Cancellation
- **Test Audio** - Verify output and microphone functionality

## 🚀 Performance Optimization

### Power Plan Features
- Ultimate Performance profile
- CPU boost maximization
- Disable hibernation and fast boot
- PCIe link state optimization
- USB and graphics latency reduction

### System Tweaks
- Network stack optimization
- Background service management
- USB selective suspend disabling
- Dynamic tick frequency optimization

## 📦 Dependencies

```xml
<PackageReference Include="NAudio" Version="2.2.1" />
<PackageReference Include="System.Management" Version="7.0.2" />
```

- **NAudio** - Audio playback and recording
- **System.Management** - System information access

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🐛 Known Issues

- Audio enhancements require administrator privileges
- Some system tweaks may require admin access
- Microphone test is currently a placeholder

## 🔮 Future Features

- [ ] Game-specific profiles
- [ ] Custom preset configurations
- [ ] Network optimizer
- [ ] Real-time FPS counter
- [ ] Discord integration
- [ ] Automatic backup/restore settings
- [ ] Multi-language support

## 📧 Contact & Support

- **GitHub Issues**: [Report a bug](https://github.com/tonykungcore-sys/FiveM-Settings-App/issues)
- **Developer**: tonykungcore-sys

## 🙏 Acknowledgments

- FiveM community for inspiration
- Open-source libraries and frameworks
- All contributors and testers

---

**Made with ❤️ for FiveM Players**
