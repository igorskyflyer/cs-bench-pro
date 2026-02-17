<div align="center">
  <img src="https://raw.githubusercontent.com/igorskyflyer/cs-bench-pro/main/media/bench-pro.png" alt="Icon of BenchPro" width="256" height="256">
  <h1>BenchPro</h1>
</div>

<blockquote align="center">High-Performance Benchmarking • System-Level Telemetry • Multi-Threaded Stress Testing • Hardware Analysis</blockquote>

<h4 align="center">
  A multi-threaded CPU stress-testing and hardware telemetry utility built with C# and Win32 Interop.
</h4>

<br>
<br>

## 📃 Table of Contents

- 🎯 [**Motivation**](#motivation)
- ✨ [**Features**](#features)
- ⚙️ [**Implementation**](#implementation)
- 🕵🏼 [**Usage**](#usage)
- 📸 [**Demo**](#demo)
- 📝 [**Changelog**](#changelog)
- 🪪 [**License**](#license)
- 💖 [**Support**](#support)
- 👨🏻‍💻 [**Author**](#author)

<br>

## Motivation
In *March 2014*, during a **Computer Architecture** course, the professor offered an alternative to the standard theoretical exam: develop a functional benchmarking utility from scratch. While the majority of the cohort opted for the written test, **Igor chose to engineer a functional solution independently.**  

Driven by an interest in low-level systems, he developed the utility without prior specialized knowledge or instructional guidance, bypassing standard .NET abstractions to query hardware directly. **BenchPro** serves as a result of that exploration into thread management, **WMI** telemetry, and custom Win32 UI rendering, proving that physical silicon performance could be mastered through self-directed research.

<br>

## Features
- **Dual-Mode Stress Testing**: Implements two distinct algorithms to saturate CPU cycles:
    - **Floating Point Operations**: Heavy arithmetic stress testing (`+`, `-`, `*`, `/`, `Math.Pow`, `Math.Log`).
    - **Monte Carlo Simulation**: A stochastic method for estimating `π (Pi)` to measure raw computational throughput.
- **Deep Hardware Telemetry**: Utilizes `Win32_Processor` via WMI to retrieve L2/L3 cache sizes, core counts, and data width.
- **Real-Time Polling**: Monitors system vitals including memory usage and battery status via a custom polling timer.
- **Proprietary UI Engine**: Features a completely frameless window architecture with custom drag-and-drop logic (`WM_NCHITTEST`), bypassing the standard Windows chrome.
- **Dynamic Theming**: Includes a custom skin engine with 7 color variations (`Blue`, `Green`, `Red`, `Purple`, `Black`, `Gray`, `Aqua`).
- **Data Export**: Supports saving benchmark results as raw text logs (`.txt`) or rendering the results visualizer to an image (`.bmp`, `.jpg`, `.png`).

<br>

## Implementation
The core architecture relies heavily on **Win32 Interop** to escape the managed sandbox of the .NET Framework 2.0/4.0.

### 1. The Interop Core
To achieve a frameless yet movable window, the application overrides the `WndProc` method to intercept Windows messages. It handles `WM_NCHITTEST` (0x84) manually, tricking the OS into treating the client area as a caption bar for dragging purposes.

### 2. Hardware Telemetry
Instead of relying on basic Environment variables, the application queries the `ManagementObjectSearcher` to pull low-level processor specifications directly from the WMI provider.

### 3. Asynchronous Benchmarking
The stress tests run on a background worker thread to prevent UI freezing. The **Monte Carlo** method generates random coordinate pairs `$(x, y)$` to determine points within a unit circle, using the ratio of success to total throws to approximate `Pi`.

<br>

## Usage
1. **Launch** the executable (`BenchPro.exe`).
2. **Select Method**: Choose between **Monte Carlo** or **Floating Point**.
3. **Configure**: Set the number of iterations.
4. **Run**: Click the "Start" button to begin the stress test.
5. **Analyze**: View real-time progress and final execution time (in ms).
6. **Export**: Use `File > Save` to export the data.  

*Note: You can change the theme via the "Skin" icon in the UI or by pressing `Ctrl + T`.*

<br>

## Demo
<div align="center">
  <figure>
    <img src="https://raw.githubusercontent.com/igorskyflyer/cs-bench-pro/main/media/screenshot.png" alt="Icon of BenchPro" width="699" height="492">
    <br>
   <figcaption>
    <strong>Figure 1.</strong> <em>A screenshot of BenchPro's user interface</em>
   </figcaption>
</div>

<br>

## Changelog
Read about the latest changes in the [**CHANGELOG**](https://github.com/igorskyflyer/cs-bench-pro/blob/main/CHANGELOG.md).

<br>

## License
Licensed under the [**GPL-3.0 license**](https://github.com/igorskyflyer/cs-bench-pro/blob/main/LICENSE).

<br>

## Support
<div align="center">
  I work hard for every project, including this one and your support means a lot to me!
  <br>
  Consider buying me a coffee. ☕
  <br>
  <br>
  <a href="https://ko-fi.com/igorskyflyer" target="_blank"><img src="https://raw.githubusercontent.com/igorskyflyer/igorskyflyer/main/assets/ko-fi.png" alt="Donate to igorskyflyer" width="180" height="46"></a>
  <br>
  <br>
  <em>Thank you for supporting my efforts!</em> 🙏😊
</div>

<br>

## Author
Created by **Igor Dimitrijević ([*@igorskyflyer*](https://github.com/igorskyflyer/))**.
