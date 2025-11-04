# 30DayMapChallenge 2025

This is my contribution to the #30DayMapChallenge for November 2025.\
About the #30DayMapChallenge , check out <https://30daymapchallenge.com/> !

## Introduction

### About me

I am currently a Principal Geomatics Engineer at the Singapore Land Authority and hold an MSc in Urban Spatial Science from the Centre for Advanced Spatial Analysis (CASA), University College London (UCL). \
I specialise in Geographic Information Systems (GIS), Remote Sensing, Data Science, and Agent-Based Modelling, while my other interests include hiking, drone piloting/photography and board games. \
For opportunities or collaboration, I can be contacted via [LinkedIn](https://www.linkedin.com/in/james-tan-song-en-76b73418a/)

### Day 5: Earth

For this theme, I explored the use of Synthetic Aperture Radar (SAR) imagery to analyse earthquake-induced ground deformation, focusing on the January 2025 Taiwanese Earthquake as the study area. Throughout the process, I gained valuable insights such as the distinction between SAR GRD and SLC products. While SLC data is essential for generating interferograms, it is unfortunately not available on Google Earth Engine.

Creating an interferogram proved to be a technically demanding task, involving several preprocessing steps such as orbit correction, image co-registration, and radiometric calibration. Despite these challenges, I successfully produced an interferogram that visually captured ground deformation, with concentric fringes tightening near the epicenter.

I attempted to export the product for SNAPHU processing to quantify displacement, but repeatedly encountered the error: "Unexpected or abnormal exit of child process." This prevented me from completing the phase unwrapping and deriving quantitative displacement data.

Nonetheless, this exercise significantly deepened my appreciation for the complexity and technical rigor involved in seismological research. I look forward to resolving the SNAPHU issues in future attempts and continuing to build on this foundation.

![Day 5](Day%205/Day%205_edited.png)

Data Source: [Copernicus](https://browser.dataspace.copernicus.eu/) - S1A_IW_SLC__1SDV_20250111T215254_20250111T215321_057402_0710E0_9355 / S1A_IW_SLC__1SDV_20250123T215253_20250123T215321_057577_0717D2_9383 \
Tutorial Source: [Tutorial For Exercise 6: InSAR for detect, map and monitor natural hazards](https://share.google/Lr4oas3KMmPbU8MLM) ; [Create an Interferogram Using ESA's Sentinel-1 Toolbox](https://www.earthdata.nasa.gov/learn/data-recipes/create-interferogram-using-esas-sentinel-1-toolbox)

### Day 4: Data: My Data

I have been playing Pokémon Go since its launch in 2016, and one feature I have found fascinating is the gift system. Gifts are collected from PokéStops and sent to friends, each tagged with its physical location. That got me thinking: if you receive enough gifts from someone, could you infer their daily patterns like where they live or work?

A few years ago, with the consent of several friends, I started recording the locations of gifts they sent me. My goal was to analyse the data and see if I could identify behavioral patterns. Although I never got around to mapping it then, I decided to use that dataset for today's challenge where I did a hotspot analysis for one friend. The results highlighted their home area and the train station they likely use for commuting. I chose this dataset in part to protect my friend's anonymity since they live in a densely populated area (compared to some of the other data), thus making it harder to single out.

This experience made me reflect on how much everyday data we generate and how it is ultimately used. For example, [Niantic](https://nianticlabs.com/news/largegeospatialmodel?hl=en) has leveraged Pokémon Go player data to build an AI-powered navigation system . It is a reminder of how our interactions with various apps aren't just fleeting moments but harnessed for various purposes (although despite that all, I am still an active player).

![Day 4](Day%204/Day%204_v2.png)

Data Source: Author's Own

### Day 3: Polygons

For last year’s #30DayMapChallenge, under the theme of polygons, I created contour polygons to visualise the elevation of the Isle of Skye. This year, I expanded on that concept by incorporating bathymetry. My focus was Crater Lake, where I developed a dual-layer terrain visualisation: one layer features elevation contours generated from the USGS 1/3 arc-second Digital Elevation Model, while the other showcases bathymetric data sourced from the USGS, the University of New Hampshire’s Center for Coastal and Ocean Mapping, and the National Park Service.

Since the bathymetry dataset dates back to 2000, I performed georeferencing to ensure accurate alignment between the elevation and depth layers. To enhance visual depth and dimensionality, I applied a subtle drop shadow effect, helping to accentuate the terrain’s contours and underwater relief.

![Day_3](Day%203/Day%203_edited_labels.png)

Data Source: [Bathymetry survey of Crater Lake 2020](https://oe.oregonexplorer.info/craterlake/bathymetry.html) ; [USGS 1/3 arc-second Digital Elevation Model](https://portal.opentopography.org/raster?opentopoID=OTNED.012021.4269.1)

### Day 2: Lines

What started as a simple plan to plot satellite orbits on a static map spiraled into an interactive 3D visualisation where you can toggle different satellites and rotate around the Earth to explore their paths. I reused the code to showcase the orbital paths of both NOAA’s polar-orbiting satellites and GOES geostationary satellites, highlighting the contrast in how they observe our planet. 

![Day 2_NOAA](Day%202/Day%202_NOAA.png)
![Day 2_GOES](Day%202/Day%202_GOES.png)

Explore the interactive map here: [NOAA](https://jamestansongen.github.io/polar-orbiting-noaa-satellites/) ; [GOES](https://jamestansongen.github.io/goes-geostationary-satellite-orbits/)

Data Source: [Satellite Orbits](https://celestrak.org/NORAD/elements/), [Global Relief Model](https://www.ngdc.noaa.gov/mgg/global/relief/ETOPO1/data/ice_surface/grid_registered/netcdf/)
Tutorial Source: [Create “Interactive Globe + Earthquake Plot in Python](https://plainenglish.io/blog/plot-satellites-real-time-orbits-with-python-s-matplotlib) ; [Plot Satellites’ Real-time Orbits with Python’s Matplotlib](https://plainenglish.io/blog/plot-satellites-real-time-orbits-with-python-s-matplotlib)

### Day 1: Points

For Day 1’s theme on Points, I used a firefly symbology where each glowing dot marks one of the 214 Wainwrights: the iconic fells of the Lake District immortalized in Alfred Wainwright’s Pictorial Guides to the Lakeland Fells (1955–1966). A constellation of summits, lighting up the landscape.

![Day 1](Day%201/Day%201_dark.png)

Data Source: [Lake District Boundaries](https://geoportal.statistics.gov.uk/datasets/ons::national-parks-december-2020-boundaries-gb-bfc/explore?location=55.167958%2C-2.950000%2C6.27
), [List and Coordinates of the Wainwrights](https://www.paulbeal.com/list-of-wainwrights/)
