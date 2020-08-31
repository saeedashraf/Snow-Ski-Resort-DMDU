# Snow-Ski-Resort-DMDU
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

This project analyses the impact of climate change on the financial situation and tipping points of Ski resorts.

repo with the code, data, and analysis for the Ski project of University of Zürich.
The repository contains the code and partial data for the manuscript:

## Getting Started
To set up a working example, clone the GitHub repository and install all software requirements listed in the requirements.txt. Main tool used is Python. Installing within an Anaconda environment is recommended.

In order to run illustrative examples six downloads are required from:


Once repository is set up locally with all code and correctly placed data, follow below instructions for each step.

## Case Studies:
In total six ski resorts were selected for this study:

1. https://www.sattel-hochstuckli.ch/en  (800m to 1200) - Central Switzerland
2. https://www.atzmaennig.ch/en/winter/  (800-1200) Zurich Region
3. https://www.hoch-ybrig.ch/en/winter/service/brochure/  (900-1900) Central Switzerland
4. https://www.villars-diablerets.ch/en/ (1200-3000)
5. https://www.champex.info/ (1486-2194)
6. https://www.davos.ch/winter/berge/jakobshorn/ (1500 - 2500)


## Climate Datasets:
CH2018 [link](https://www.nccs.admin.ch/nccs/en/home/the-nccs/priority-themes/ch2018-climate-scenarios.html)


## Framework:
<details>
<summary>T1 - <i><b>Climate Scenario</b></i></summary>

### Topics
`CH2018`

In this task, the data of located climate grids inside each Ski resorts are extracted from CH2018 datasets.

###  Literature
CH2018 "Switzerland CH2018 climate scenarios" [here](https://www.nccs.admin.ch/nccs/en/home/the-nccs/priority-themes/ch2018-climate-scenarios.html)
</details>


<details>
<summary>T2 - <i><b>Snow Model</b></i></summary>

### Topics
`Snow model` `Ablation` `Accumulation`

In this task, a modular grid-based snow model was developed. The current model consists of Ablation, and Accumulation modules, with the possibility of adding new modules in the future. The main

###  Literature
Marty (2017) "How much can we save? Impact of different emission scenarios on future snow cover in the Alps" [link](https://www.the-cryosphere.net/11/517/2017/)

Farinotti (2012) "Runoff evolution in the Swiss Alps: projections for selected high-alpine catchments based on ENSEMBLES scenarios" [link](https://onlinelibrary.wiley.com/doi/abs/10.1002/hyp.8276)

Huss (2008a) "Determination of the seasonal mass balance of four Alpine glaciers since 1865" [link](https://agupubs.onlinelibrary.wiley.com/doi/full/10.1029/2007JF000803)

Huss (2008b) "Modelling runoff from highly glacierized alpine drainage basins in a changing climate" [link](https://onlinelibrary.wiley.com/doi/10.1002/hyp.7055)

Hock (2005)"Glacier melt: a review of processes and their modelling" [link](https://journals.sagepub.com/doi/10.1191/0309133305pp453ra)

</details>

<details>
<summary>T3 - <i><b>Deep uncertainty in climate scenarios</b></i></summary>

### Topics
`Deep Uncertainty`

In this task a python code was developed to produce new climate scenarios based on CH2018 dataset

###  Literature
van Ginkel et al (2020), "Climate change induced socio-economic tipping points" [link](https://iopscience.iop.org/article/10.1088/1748-9326/ab6395)

Kwakkel (2017), "The Exploratory Modeling Workbench: An open source toolkit for exploratory modeling, scenario discovery, and (multi-objective) robust decision making"  [link](https://www.sciencedirect.com/science/article/pii/S1364815217301251)

Damm et al (2014), "Does artificial snow production pay under future climate conditions?"[link](https://www.sciencedirect.com/science/article/abs/pii/S0261517714000107?via%3Dihub)
###  Notebooks
Code_Python_15. [Precipitation and temperature generator](tmp_pcp_Generator.py)

</details>

<details>
<summary>T4 - <i><b>Decision Making under Deep Uncertainty _ simulations</b></i></summary>

### Topics
`Deep Uncertainty` `Decision Making`

In this task, a python code will be developed to connect our existing notebooks (No.1, No.4) to the Exploratory Modelling and Analysis (EMA) Workbench [here](https://emaworkbench.readthedocs.io/en/latest/)

###  Literature
van Ginkel et al (2020), "Climate change induced socio-economic tipping points" [link](https://iopscience.iop.org/article/10.1088/1748-9326/ab6395)

Kwakkel (2017), "The Exploratory Modeling Workbench: An open source toolkit for exploratory modeling, scenario discovery, and (multi-objective) robust decision making"  [link](https://www.sciencedirect.com/science/article/pii/S1364815217301251)

Damm et al (2014), "Does artificial snow production pay under future climate conditions?"[link](https://www.sciencedirect.com/science/article/abs/pii/S0261517714000107?via%3Dihub)

###  Notebooks
Code_Python_16. [XLR_framework_python](XLR_Framework_setup1.py)

</details>

<details>
<summary>T5 - <i><b>Decision Making under Deep Uncertainty _ Visualization</b></i></summary>

###  Literature

###  Notebooks
No17. [XLR_Visualization_version9](snow_model_vcloned_v9_randomness_case3_Hoch_Ybrigh_setup1.ipynb)

</details>

## All the Jupyter notebooks and Python codes of the project:
All the codes are presented here:

Code_Python_15. [Precipitation and temperature generator](tmp_pcp_Generator.py)

Code_Python_16. [XLR_framework_python](XLR_Framework_setup1.py)

No17. [XLR_Visualization_version9](snow_model_vcloned_v9_randomness_case3_Hoch_Ybrigh_setup1.ipynb)


## Outputs:
The results of the snow model (csv format) for the case studies are collected. In these analyses, no elevation bands were considered for Villars-Diablerets and Jakobshorn case studies.

After considering elevation bands (500m) for the case study No.4 (Villars-Diableret) and No.6 ( Jakobshorn), new results were generated.

After considering the uncertainty of climate scenarios by producing 68 new climate scenarios, and running the snow model, the new results were produced


### Prerequisites

Manuscript:

## Acknowledgments

Thanks to all our collaborators at the UZH, Deltares, SLF and all other colleagues who contributed with their advice.
