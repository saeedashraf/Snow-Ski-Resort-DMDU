# snow-ski-resort-finance
This project analyses the impact of climate change on the financial situation of Ski resorts.

\n\n\n


## Datasets:
1. https://www.sattel-hochstuckli.ch/en  (800m to 1200) - Central Switzerland
2. https://www.hoch-ybrig.ch/en/winter/service/brochure/  (900-1900) Central Switzerland
3. https://www.atzmaennig.ch/en/winter/  (800-1200) Zurich Region
4. https://www.villars-diablerets.ch/en/ (1200-3000)
5. https://www.champex.info/ (1486-2194)
6. https://www.davos.ch/winter/berge/jakobshorn/ (1500 - 2500)


## Input Datasets:
CH2018 [link] (https://www.nccs.admin.ch/nccs/en/home/the-nccs/priority-themes/ch2018-climate-scenarios.html)

## Framework:

<details>
<summary>T1 - <i>Snow Model</i></summary>

### Topics
`Snow model overview`
`Snow model for grids`

The main modular snow model consists of Ablation, and Accumulation modules.

###  Literature
Farinotti (2012) [link](https://onlinelibrary.wiley.com/doi/abs/10.1002/hyp.8276)

Huss (2008a) [link](https://agupubs.onlinelibrary.wiley.com/doi/full/10.1029/2007JF000803)

Huss (2008b) [link](https://onlinelibrary.wiley.com/doi/10.1002/hyp.7055)

Hock (2005)[link](https://journals.sagepub.com/doi/10.1191/0309133305pp453ra)


###  Notebooks 
1. [snowModel version 1](snowmodel_py/snow_model_v1.ipynb)
</details>

<details>
<summary>T2 - <i>Snow Model post processing</i></summary>

### Topics
`Visualization of snow model results`
`Visualization of tipping points`
###  Notebooks
1. [Visualization of snow model](snowModel2_Visualization.ipynb)

2. [Visualization of snow model with elevation band](snowModel2_Visualization_elevBand.ipynb)

</details>

<details>
<summary>T3 - <i>Deep uncertainty in climate scenarios</i></summary>

### Topics
`Deep Uncertainy`

In this task a paython code was developed to produce new climate scenarios based on CH2018 dataset

###  Literature
van Ginkel et al (2020), "Climate change induced socio-economic tipping points"
https://iopscience.iop.org/article/10.1088/1748-9326/ab6395

Kwakkel (2017), "The Exploratory Modeling Workbench: An open source toolkit for exploratory modeling, scenario discovery, and (multi-objective) robust decision making"
https://www.sciencedirect.com/science/article/pii/S1364815217301251

Damm et al (2014), "Does artificial snow production pay under future climate conditions?"
https://www.sciencedirect.com/science/article/abs/pii/S0261517714000107?via%3Dihub

###  Notebooks
1. [Randomness notebook](randomness_tmp_pcp.ipynb)

2. [Visualization of snow model outputs](snowModel2_randomness_Visualization.ipynb)

3. [Visualization of snow model outpts with elevation bands](snowModel2_randomness_Visualization_elevBand.ipynb)

</details>


