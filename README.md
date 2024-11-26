<img src="Images/AutoDRIVE-Banner.jpg">

<p align="center">
<img alt='GitHub Stars' src="https://img.shields.io/github/stars/Tinker-Twins/AutoDRIVE?style=flat&color=blue&label=Stars&logo=github&logoColor=white">
<img alt='GitHub Forks' src="https://img.shields.io/github/forks/Tinker-Twins/AutoDRIVE?style=flat&color=blue&label=Forks&logo=github&logoColor=white">
<img alt='GitHub Downloads' src="https://img.shields.io/github/downloads/Tinker-Twins/AutoDRIVE/total?color=blue&label=Downloads&logo=github&logoColor=white">
<img alt='GitHub Clones' src='https://img.shields.io/badge/dynamic/json?color=blue&label=Clones&query=count&url=https://gist.githubusercontent.com/Tinker-Twins/e2855ef0fa018279b206045be92424cb/raw/clone.json&logo=github'>
</p>

## Project Overview

![](Images/AutoDRIVE-Overview.png)

<p align="justify">
AutoDRIVE is envisioned to be an integrated platform for autonomous driving research and education. It bridges the gap between software simulation and hardware deployment by providing the AutoDRIVE Simulator and AutoDRIVE Testbed, a well-suited duo for sim2real applications. It also offers AutoDRIVE Devkit, a developer's kit for rapid and flexible development of autonomy algorithms. Although the platform is primarily targeted towards autonomous driving, it also supports the development of smart-city solutions for managing the traffic flow.
</p>

## AutoDRIVE Testbed

| <img src="Images/Testbed-Vehicle.png" width="500"> | <img src="Images/Testbed-Infrastructure.png" width="500"> |
|:--------:|:-------------:|
| Vehicle | Infrastructure |

<p align="justify">
AutoDRIVE Testbed is the hardware setup comprising of a scaled vehicle model (called Nigel) and a modular infrastructure development kit. The vehicle is equipped with a comprehensive sensor suite for redundant perception, a set of actuators for constrained motion control and a fully functional lighting system for illumination and signaling. It can be teleoperated (in manual mode) or self-driven (in autonomous mode). The infrastructure development kit comprises of various environment modules along with active and passive traffic elements.
</p>

- **Source Branch:** [AutoDRIVE Testbed](https://github.com/Tinker-Twins/AutoDRIVE/tree/AutoDRIVE-Testbed)
- **Latest Release:** [AutoDRIVE Testbed 0.2.0](https://github.com/Tinker-Twins/AutoDRIVE/releases/tag/Testbed-0.2.0)
- **Upcoming Release:** AutoDRIVE Testbed 0.3.0 is currently under development.
- **Nigel (AS) Build Documentation:** [Assembly Guide](https://github.com/Tinker-Twins/AutoDRIVE/blob/AutoDRIVE-Testbed/Documents/Nigel%20-%20Assembly%20Guide.pdf), [Assembly Animation](https://youtu.be/0wQqMQN9PJY?feature=shared) and [BOM](https://github.com/Tinker-Twins/AutoDRIVE/blob/AutoDRIVE-Testbed/Documents/BOM.pdf)
- **Nigel (4WD4WS) Build Documentation:** [Assembly Guide](https://github.com/Tinker-Twins/AutoDRIVE/blob/AutoDRIVE-Testbed/Documents/Nigel%204WD4WS%20-%20Assembly%20Guide.pdf), [Assembly Animation](https://youtu.be/PsjJeoElGiI?feature=shared) and [BOM](https://github.com/Tinker-Twins/AutoDRIVE/blob/AutoDRIVE-Testbed/Documents/BOM.pdf)

## AutoDRIVE Simulator

| <img src="Images/Simulator-Vehicle.png" width="500"> | <img src="Images/Simulator-Infrastructure.png" width="500"> |
|:--------:|:-------------:|
| Vehicle | Infrastructure |

<p align="justify">
AutoDRIVE Simulator is the digital twin of the AutoDRIVE Testbed, which enables the users to virtually prototype their algorithms either due to hardware limitations or as a part of the reiterative development cycle. It is developed atop the Unity game engine and offers a WebSocket interface for bilateral communication with the autonomy algorithms developed independently using the AutoDRIVE Devkit. The standalone simulator application is targeted at Full HD resolution (1920x1080p) with cross-platform support (Windows, macOS and Linux). It is a light-weight software application that utilizes system resources wisely. This enables deployment of the simulator application and autonomy algorithms on a single machine; nonetheless, distributed computing is also supported.
</p>

- **Source Branch:** [AutoDRIVE Simulator](https://github.com/Tinker-Twins/AutoDRIVE/tree/AutoDRIVE-Simulator)
- **Latest Release:** [AutoDRIVE Simulator 0.3.0](https://github.com/Tinker-Twins/AutoDRIVE/releases/tag/Simulator-0.3.0)
- **Upcoming Release:** AutoDRIVE Simulator 0.4.0 is currently under development.

## AutoDRIVE Devkit

| <img src="Images/ADSS.png" width="500"> | <img src="Images/SCSS.png" width="500"> |
|:--------:|:-------------:|
| ADSS Toolkit | SCSS Toolkit |

<p align="justify">
AutoDRIVE Devkit is a developer's kit that enables the users to exploit AutoDRIVE Simulator or AutoDRIVE Testbed for rapid and flexible development of autonomy algorithms pertaining to autonomous driving (using ADSS Toolkit) as well as smart city management (using SCSS Toolkit). It supports local (decentralized) as well as distributed (centralized) computing and is compatible with Robot Operating System (ROS), while also offering a direct scripting support for Python and C++.
</p>

- **Source Branch:** [AutoDRIVE Devkit](https://github.com/Tinker-Twins/AutoDRIVE/tree/AutoDRIVE-Devkit)
- **Latest Release:** [AutoDRIVE Devkit 0.3.0](https://github.com/Tinker-Twins/AutoDRIVE/releases/tag/Devkit-0.3.0)
- **Upcoming Release:** AutoDRIVE Devkit 0.4.0 is currently under development.

## Awards and Recognition
- [Finalist Award](https://sites.google.com/site/asmemrc/design-competition-showcase/2023-finalists#h.k763k3hc2lfu) for project "Nigel: A Mechatronically Redundant and Reconfigurable Scaled Autonomous Vehicle of AutoDRIVE Ecosystem" at ASME Student Mechanism and Robot Design Competition (SMRDC) 2023
- [Best Paper Award](http://ccris2023.net/ccris2021.html) for paper "AutoDRIVE Simulator: A Simulator for Scaled Autonomous Vehicle Research and Education" at CCRIS 2021
- [Best Project Award](https://www.youtube.com/watch?v=VUo4UFiTnd4&t=4048s) for "AutoDRIVE – An Integrated Platform for Autonomous Driving Research and Education" at National Level IEEE Project Competition 2021
- [Best Project Award](https://youtu.be/2FByDOkDxMc?t=1892) for "AutoDRIVE – An Integrated Platform for Autonomous Driving Research and Education" at SRMIST Mechatronics Department 2021
- [Gold Medal](https://arxiv.org/abs/2211.08475) for paper "AutoDRIVE – An Integrated Platform for Autonomous Driving Research and Education" at SRMIST Research Day 2021
- [Lightning Talk](https://vimeo.com/480566576) of "AutoDRIVE Simulator: A Simulator for Scaled Autonomous Vehicle Research and Education" at ROS World 2020
- [India Connect @ NTU Research Fellowship](https://arxiv.org/abs/2211.07022v2) 2020 for "AutoDRIVE Simulator"

## Resources

### Highlights

We encourage you to take a look at the following quick highlights to keep up with the recent advances in AutoDRIVE Ecosystem.

|                    |
|:------------------:|
| [<img src="Images/AutoDRIVE-Ecosystem-Pitch-Video.png">](https://youtu.be/t0CgNR_LgrQ) |
| [AutoDRIVE Ecosystem Pitch Video](https://youtu.be/t0CgNR_LgrQ) |
|                    |

|                    |                     |
|:------------------:|:-------------------:|
| [<img src="Images/AutoDRIVE-Simulator-Pitch-Video.png" width="500">](https://youtu.be/i7R79jwnqlg) | [<img src="Images/AutoDRIVE-Testbed-Pitch-Video.png" width="500">](https://youtu.be/YFQzyfXV6Rw) |
| [AutoDRIVE Simulator Pitch Video](https://youtu.be/i7R79jwnqlg) | [AutoDRIVE Testbed Pitch Video](https://youtu.be/YFQzyfXV6Rw) |
| [<img src="Images/Nigel-4WD4WS-Feature-Video.png" width="500">](https://youtu.be/UVIShZuZmpg) | [<img src="Images/F1TENTH-in-AutoDRIVE-Simulator.png" width="500">](https://youtu.be/Rq7Wwcwn1uk) |
| [Nigel 4WD4WS Feature Video](https://youtu.be/UVIShZuZmpg) | [F1TENTH in AutoDRIVE Simulator](https://youtu.be/Rq7Wwcwn1uk) |
| [<img src="Images/OpenCAV-in-AutoDRIVE-Simulator.png" width="500">](https://youtu.be/YIZz_8rLgZQ) | [<img src="Images/RZR-in-AutoDRIVE-Simulator.png" width="500">](https://youtu.be/PLW1-sYW6Hw) |
| [OpenCAV in AutoDRIVE Simulator](https://youtu.be/YIZz_8rLgZQ) | [RZR in AutoDRIVE Simulator](https://youtu.be/PLW1-sYW6Hw) |
| [<img src="Images/Parallel-RL-using-AutoDRIVE-Simulator.png" width="500">](https://youtu.be/UAIcgeZ-at8) | [<img src="Images/Deformable-Terrain-Demo.png" width="500">](https://youtu.be/N8oZdD-WGYU) |
| [Parallel RL using AutoDRIVE Simulator](https://youtu.be/UAIcgeZ-at8) | [Deformable Terrain in AutoDRIVE Simulator](https://youtu.be/N8oZdD-WGYU) |
| [<img src="Images/Nigel-Variability-Testing.png" width="500">](https://youtu.be/KtjZapz0OkE) | [<img src="Images/OpenCAV-Variability-Testing.png" width="500">](https://youtu.be/sW8Ic-XyufM) |
| [Variability Testing using Nigel](https://youtu.be/KtjZapz0OkE) | [Variability Testing using OpenCAV](https://youtu.be/sW8Ic-XyufM) |
|                    |                     |

### Demonstrations

We encourage you to take a look at the following research projects developed using the AutoDRIVE Ecosystem.

|                    |                     |
|:------------------:|:-------------------:|
| [<img src="Images/Autonomous-Parking.png" width="500">](https://youtu.be/piCyvTM2dek) | [<img src="Images/Behavioural-Cloning.png" width="500">](https://youtu.be/rejpoogaXOE) |
| [Autonomous Parking](https://youtu.be/piCyvTM2dek) | [Behavioural Cloning](https://youtu.be/rejpoogaXOE) |
| [<img src="Images/Intersection-Traversal.png" width="500">](https://youtu.be/AEFJbDzOpcM) | [<img src="Images/Smart-City-Management.png" width="500">](https://youtu.be/fnxOpV1gFXo) |
| [Intersection Traversal](https://youtu.be/AEFJbDzOpcM) | [Smart City Management](https://youtu.be/fnxOpV1gFXo) |
|                    |                     |

### Presentations

We encourage you to take a look at the following presentations to gain a better insight into the AutoDRIVE Ecosystem.

|                    |                     |
|:------------------:|:-------------------:|
| [<img src="Images/SRMIST-FYP-Viva-Voce.png" width="500">](https://youtu.be/2FByDOkDxMc) | [<img src="Images/CCRIS-2021-Presentation.png" width="500">](https://youtu.be/whTH6VyVtHE) |
| [SRMIST UG Final Year Project Viva Voce](https://youtu.be/2FByDOkDxMc) | [CCRIS 2021 Virtual Presentation](https://youtu.be/whTH6VyVtHE) |
| [<img src="Images/AutoDRIVE-Technical-Discussion.png" width="500">](https://youtu.be/nV7HuLTjUY4) | [<img src="Images/Autoware-COE-Seminar.png" width="500">](https://youtu.be/WTGOAiRX4b0) |
| [AutoDRIVE Technical Discussion @ ARMLab CU-ICAR](https://youtu.be/nV7HuLTjUY4) | [Autoware COE Seminar](https://youtu.be/WTGOAiRX4b0) |
| [<img src="Images/AIM-2023-Presentation.png" width="500">](https://youtu.be/PV9k3-N_bvc) | [<img src="Images/OpenCAV-Technical-Discussion.png" width="500">](https://youtu.be/xihFoUxU7EU) |
| [AIM 2023 Video Presentation](https://youtu.be/PV9k3-N_bvc) | [OpenCAV Technical Discussion @ ARMLab CU-ICAR](https://youtu.be/xihFoUxU7EU) |
| [<img src="Images/OpenCAV-AuE-Seminar.png" width="500">](https://youtu.be/bk7lJfD4H0s) | [<img src="Images/SMRDC-2023-Presentation.png" width="500">](https://youtu.be/R_GZ1LkMWGQ) |
| [OpenCAV CUICAR AuE Seminar](https://youtu.be/bk7lJfD4H0s) | [SMRDC 2023 Finalist Pitch](https://youtu.be/R_GZ1LkMWGQ) |
| [<img src="Images/MECC-2023-Presentation.png" width="500">](https://youtu.be/0yS1-RpqhcE) | [<img src="Images/IROS-2023-Presentation.png" width="500">](https://youtu.be/8jyCJUOaLaI) |
| [MECC 2023 Video Presentation](https://youtu.be/0yS1-RpqhcE) | [IROS 2023 Presentation](https://youtu.be/8jyCJUOaLaI) |
|                    |                     |

### Publications

We encourage you to read and cite the relevant papers if you use any part of this project for your research:

#### [AutoDRIVE: A Comprehensive, Flexible and Integrated Digital Twin Ecosystem for Enhancing Autonomous Driving Research and Education](https://arxiv.org/abs/2212.05241)
```bibtex
@article{AutoDRIVE-Ecosystem-2023,
author = {Samak, Tanmay and Samak, Chinmay and Kandhasamy, Sivanathan and Krovi, Venkat and Xie, Ming},
title = {AutoDRIVE: A Comprehensive, Flexible and Integrated Digital Twin Ecosystem for Autonomous Driving Research and Education},
journal = {Robotics},
volume = {12},
year = {2023},
number = {3},
article-number = {77},
url = {https://www.mdpi.com/2218-6581/12/3/77},
issn = {2218-6581},
doi = {10.3390/robotics12030077}
}
```
This work has been published in **MDPI Robotics.** The open-access publication can be found on [MDPI](https://doi.org/10.3390/robotics12030077).

#### [AutoDRIVE Simulator: A Simulator for Scaled Autonomous Vehicle Research and Education](https://arxiv.org/abs/2103.10030)
```bibtex
@inproceedings{AutoDRIVE-Simulator-2021,
author = {Samak, Tanmay Vilas and Samak, Chinmay Vilas and Xie, Ming},
title = {AutoDRIVE Simulator: A Simulator for Scaled Autonomous Vehicle Research and Education},
year = {2021},
isbn = {9781450390453},
publisher = {Association for Computing Machinery},
address = {New York, NY, USA},
url = {https://doi.org/10.1145/3483845.3483846},
doi = {10.1145/3483845.3483846},
booktitle = {2021 2nd International Conference on Control, Robotics and Intelligent System},
pages = {1–5},
numpages = {5},
location = {Qingdao, China},
series = {CCRIS'21}
}
```
This work has been published at **2021 International Conference on Control, Robotics and Intelligent System (CCRIS).** The publication can be found on [ACM Digital Library](https://dl.acm.org/doi/abs/10.1145/3483845.3483846).

#### [Towards Mechatronics Approach of System Design, Verification and Validation for Autonomous Vehicles](https://arxiv.org/abs/2301.13425)
```bibtex
@inproceedings{AutoDRIVE-Mechatronics-2023,
author = {Samak, Chinmay and Samak, Tanmay and Krovi, Venkat},
booktitle = {2023 IEEE/ASME International Conference on Advanced Intelligent Mechatronics (AIM)}, 
title = {Towards Mechatronics Approach of System Design, Verification and Validation for Autonomous Vehicles}, 
year = {2023},
volume = {},
number = {},
pages = {1208-1213},
doi = {10.1109/AIM46323.2023.10196233},
url = {https://doi.org/10.1109/AIM46323.2023.10196233}
}
```
This work has been published at **2023 IEEE/ASME International Conference on Advanced Intelligent Mechatronics (AIM).** The publication can be found on [IEEE Xplore](https://ieeexplore.ieee.org/document/10196233).

#### [Towards Sim2Real Transfer of Autonomy Algorithms using AutoDRIVE Ecosystem](https://arxiv.org/abs/2307.13272)
```bibtex
@article{Sim2Real-Transfer-2023,
author = {Chinmay Samak and Tanmay Samak and Venkat Krovi},
title = {Towards Sim2Real Transfer of Autonomy Algorithms using AutoDRIVE Ecosystem},
journal = {IFAC-PapersOnLine},
volume = {56},
number = {3},
pages = {277-282},
year = {2023},
note = {3rd Modeling, Estimation and Control Conference MECC 2023},
issn = {2405-8963},
doi = {https://doi.org/10.1016/j.ifacol.2023.12.037},
url = {https://www.sciencedirect.com/science/article/pii/S2405896323023704}
}
```
This work has been accepted at **2023 AACC/IFAC Modeling, Estimation and Control Conference (MECC).** The open-access publication can be found on [ScienceDirect](https://doi.org/10.1016/j.ifacol.2023.12.037).

#### [Multi-Agent Deep Reinforcement Learning for Cooperative and Competitive Autonomous Vehicles using AutoDRIVE Ecosystem](https://arxiv.org/abs/2309.10007)
```bibtex
@eprint{AutoDRIVE-MARL-2023,
author = {Tanmay Vilas Samak and Chinmay Vilas Samak and Venkat Krovi},
title = {Multi-Agent Deep Reinforcement Learning for Cooperative and Competitive Autonomous Vehicles using AutoDRIVE Ecosystem}, 
year = {2023},
eprint = {2309.10007},
archivePrefix = {arXiv},
primaryClass = {cs.RO},
url = {https://arxiv.org/abs/2309.10007}
}
```
This work has been accepted as Multi-Agent Dynamic Games (MAD-Games) Workshop paper at **2023 IEEE/RSJ International Conference on Intelligent Robots and Systems (IROS).** The publication can be found on [MAD-Games Workshop Website](https://iros2023-madgames.f1tenth.org/papers/samak.pdf).

#### [Nigel - Mechatronic Design and Robust Sim2Real Control of an Over-Actuated Autonomous Vehicle](https://arxiv.org/abs/2401.11542)
```bibtex
@article{Nigel-4WD4WS-2024,
author = {Samak, Chinmay V. and Samak, Tanmay V. and Velni, Javad M. and Krovi, Venkat N.},
title = {Nigel—Mechatronic Design and Robust Sim2Real Control of an Overactuated Autonomous Vehicle}, 
journal = {IEEE/ASME Transactions on Mechatronics}, 
year = {2024},
volume = {29},
number = {4},
pages = {2785-2793},
doi = {10.1109/TMECH.2024.3401077},
url = {https://doi.org/10.1109/TMECH.2024.3401077}
}
```
This work has been accepted in **IEEE/ASME Transactions on Mechatronics (TMECH)** and additionally accepted to be presented at **2024 IEEE/ASME International Conference on Advanced Intelligent Mechatronics (AIM).** The publication can be found on [IEEE Xplore](https://doi.org/10.1109/TMECH.2024.3401077).

#### [Towards Validation of Autonomous Vehicles Across Scales using an Integrated Digital Twin Framework](https://arxiv.org/abs/2402.12670)
```bibtex
@inproceedings{AutoDRIVE-Autoware-2024,
author = {Samak, Tanmay Vilas and Samak, Chinmay Vilas and Krovi, Venkat Narayan},
title = {Towards Validation of Autonomous Vehicles Across Scales using an Integrated Digital Twin Framework}, 
booktitle = {2024 IEEE International Conference on Advanced Intelligent Mechatronics (AIM)}, 
year = {2024},
volume = {},
number = {},
pages = {1068-1075},
doi = {10.1109/AIM55361.2024.10637205},
url = {https://doi.org/10.1109/AIM55361.2024.10637205}
}
```
This work has been accepted at **2024 IEEE/ASME International Conference on Advanced Intelligent Mechatronics (AIM).** The publication can be found on [IEEE Xplore](https://ieeexplore.ieee.org/document/10637205).

#### [Off-Road Autonomy Validation Using Scalable Digital Twin Simulations Within High-Performance Computing Clusters](https://arxiv.org/abs/2405.04743)
```bibtex
@inproceedings{DT-HPC-VnV-2024,
author = {{Samak, Tanmay} and {Samak, Chinmay} and {Krovi, Venkat} and {Binz, Joey} and {Luo, Feng} and {Smereka, Jonathon} and {Brudnak, Mark} and {Gorsich, David}},
title = {Off-Road Autonomy Validation Using Scalable Digital Twin Simulations Within High-Performance Computing Clusters},
booktitle = {2024 NDIA Michigan Chapter Ground Vehicle Systems Engineering and Technology Symposium},
publisher = {National Defense Industrial Association},
month = {sep},
year = {2024},
doi = {10.4271/2024-01-4111},
url = {https://doi.org/10.4271/2024-01-4111}
}
```
This work has been accepted at **2024 Ground Vehicle Systems Engineering and Technology Symposium (GVSETS).** The publication can be found on [GVSETS Library](https://ndia-mich.org/images/events/gvsets/2024/papers/MSPV/320PMO~1.PDF), and is archived on [SAE Mobilus](https://doi.org/10.4271/2024-01-4111).

#### [Metaverse for Safer Roadways: An Immersive Digital Twin Framework for Exploring Human-Autonomy Coexistence in Urban Transportation Systems](https://arxiv.org/abs/2406.05465)
```bibtex
@eprint{samak2024metaversesaferroadwaysimmersive,
author = {Tanmay Vilas Samak and Chinmay Vilas Samak and Venkat Narayan Krovi},
title = {Metaverse for Safer Roadways: An Immersive Digital Twin Framework for Exploring Human-Autonomy Coexistence in Urban Transportation Systems}, 
year = {2024},
eprint = {2406.05465},
archivePrefix = {arXiv},
primaryClass = {cs.RO},
url = {https://arxiv.org/abs/2406.05465}
}
```
This work has been accepted at **2024 IEEE/ASME International Conference on Advanced Intelligent Mechatronics (AIM).**

#### [A Scalable and Parallelizable Digital Twin Framework for Sustainable Sim2Real Transition of Multi-Agent Reinforcement Learning Systems](https://arxiv.org/abs/2403.10996)
```bibtex
@eprint{AutoDRIVE-DT-MARL-2024,
author = {Chinmay Vilas Samak and Tanmay Vilas Samak and Venkat Krovi},
title = {A Scalable and Parallelizable Digital Twin Framework for Sustainable Sim2Real Transition of Multi-Agent Reinforcement Learning Systems}, 
year = {2024},
eprint = {2403.10996},
archivePrefix = {arXiv},
primaryClass = {cs.RO},
url = {https://arxiv.org/abs/2403.10996}
}
```

### Technical Reports

We encourage you to read and cite the relevant technical reports if you use any part of this project for your research (these can serve as a good source of documentation as well):

#### [AutoDRIVE - Technical Report](https://arxiv.org/abs/2211.08475)
```bibtex
@misc{AutoDRIVE-Technical-Report,
doi = {10.48550/ARXIV.2211.08475},
url = {https://arxiv.org/abs/2211.08475},
author = {Samak, Tanmay Vilas and Samak, Chinmay Vilas},
keywords = {Robotics (cs.RO), FOS: Computer and information sciences, FOS: Computer and information sciences},
title = {AutoDRIVE - Technical Report},
publisher = {arXiv},
year = {2022},
copyright = {arXiv.org perpetual, non-exclusive license},
url = {https://arxiv.org/abs/2211.08475}
}
```

#### [AutoDRIVE Simulator - Technical Report](https://arxiv.org/abs/2211.07022)
```bibtex
@misc{AutoDRIVE-Simulator-Technical-Report,
doi = {10.48550/ARXIV.2211.07022},
url = {https://arxiv.org/abs/2211.07022},
author = {Samak, Tanmay Vilas and Samak, Chinmay Vilas},
keywords = {Robotics (cs.RO), FOS: Computer and information sciences, FOS: Computer and information sciences},
title = {AutoDRIVE Simulator - Technical Report},
publisher = {arXiv},
year = {2022},
copyright = {arXiv.org perpetual, non-exclusive license},
url = {https://arxiv.org/abs/2211.07022}
}
```
#### [Autonomy Oriented Digital Twins for Real2Sim2Real Autoware Deployment](https://arxiv.org/abs/2402.14739)
```bibtex
@misc{AutoDRIVE-Autoware-Technical-Report,
doi = {10.48550/arXiv.2402.14739},
url = {https://doi.org/10.48550/arXiv.2402.14739},
author = {Chinmay Vilas Samak and Tanmay Vilas Samak},
title = {Autonomy Oriented Digital Twins for Real2Sim2Real Autoware Deployment},
year = {2024},
eprint = {2402.14739},
archivePrefix = {arXiv},
primaryClass = {cs.RO}
copyright = {arXiv.org perpetual, non-exclusive license},
url = {https://arxiv.org/abs/2402.14739}
}
```

## Team

#### Developers

|                    |                     |
|:------------------:|:-------------------:|
| [<img src="Images/Developer-Tanmay-Samak.png" width="125">](https://www.linkedin.com/in/samaktanmay) | [<img src="Images/Developer-Chinmay-Samak.png" width="125">](https://www.linkedin.com/in/samakchinmay) |
| [Tanmay Vilas Samak](https://www.linkedin.com/in/samaktanmay) | [Chinmay Vilas Samak](https://www.linkedin.com/in/samakchinmay) |
|                    |                     |

#### Contributors

|                    |                     |                     |                     |
|:------------------:|:-------------------:|:-------------------:|:-------------------:|
| [<img src="Images/Contributor-Rohit-Ravikumar.png" width="125">](https://www.linkedin.com/in/rohitravikumar-) | [<img src="Images/Contributor-Parth-Shinde.png" width="125">](https://www.linkedin.com/in/parthshindelink) | [<img src="Images/Contributor-Joey-Binz.png" width="125">](https://www.linkedin.com/in/joey-binz) | [<img src="Images/Contributor-Giovanni-Martino.png" width="125">](https://www.linkedin.com/in/giovannimartinose) |
| [Rohit Ravikumar](https://www.linkedin.com/in/rohitravikumar-) | [Parth Shinde](https://www.linkedin.com/in/parthshindelink) | [Joey Binz](https://www.linkedin.com/in/joey-binz) | [Giovanni Martino](https://www.linkedin.com/in/giovannimartinose) |
|                    |                     |                     |                     |

#### Mentors

|                    |                     |                     |
|:------------------:|:-------------------:|:-------------------:|
| [<img src="Images/Mentor-Venkat-Krovi.png" width="125">](https://www.linkedin.com/in/venkatnkrovi) | [<img src="Images/Mentor-Sivanathan-Kandhasamy.png" width="125">](https://www.linkedin.com/in/dr-sivanathan-kandhasamy-a4703966) | [<img src="Images/Mentor-Ming-Xie.png" width="125">](https://www.linkedin.com/in/ming-xie-800a4aa1) |
| [Dr. Venkat Krovi](https://www.linkedin.com/in/venkatnkrovi) | [Dr. Sivanathan Kandhasamy](https://www.linkedin.com/in/dr-sivanathan-kandhasamy-a4703966) | [Dr. Ming Xie](https://www.linkedin.com/in/ming-xie-800a4aa1) |
|                    |                     |                     |

#### Institutions

|                    |                     |                     |
|:------------------:|:-------------------:|:-------------------:|
| [<img src="Images/Institution-CUICAR.png" width="250">](https://cuicar.com) | [<img src="Images/Institution-SRMIST.png" width="250">](https://www.srmist.edu.in/) | [<img src="Images/Institution-NTU.png" width="250">](https://www.ntu.edu.sg) |
| [CU-ICAR](https://cuicar.com) | [SRM-IST](https://www.srmist.edu.in) | [NTU](https://www.ntu.edu.sg) |
|                    |                     |                     |
