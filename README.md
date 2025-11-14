# 30DayMapChallenge 2025

This is my contribution to the #30DayMapChallenge for November 2025.\
About the #30DayMapChallenge , check out <https://30daymapchallenge.com/> !

## Introduction

### About me

I am currently a Principal Geomatics Engineer at the Singapore Land Authority and hold an MSc in Urban Spatial Science from the Centre for Advanced Spatial Analysis (CASA), University College London (UCL). \
I specialise in Geographic Information Systems (GIS), Remote Sensing, Data Science, and Agent-Based Modelling, while my other interests include hiking, drone piloting/photography and board games. \
For opportunities or collaboration, I can be contacted via [LinkedIn](https://www.linkedin.com/in/james-tan-song-en-76b73418a/)

### Day 14: Data: OpenStreetMap

Nothing fancy today, hit a bit of a geomatics/geospatial/cartographer’s block. Tried two different takes on Tokyo with prettymaps: 1) Circuit board style and 2) Cyberpunk colour scheme.

![Day 14](Day%2014/Day%2014_circuitboard.png)
![Day 14](Day%2014/Day%2014_cyberpunk.png)

### Day 13: 10 Minute Map

Now this map took me less than 10 minutes to make (because I spent more than 10 minutes during last year's challenge making a similar visualisation). The main differences this time were adjusting the region of interest and adding labels to some of the cities in New Zealand. Using the VIIRS sensor data and choosing max pixel value for the whole month of June 2025, one is able to see which areas experience strong aurora activities.

Reflecting on the theme of fast maps, humans probably cannot match AI in terms of speed. But looking at all the various entries this year I think humans still excel in creativity (and maybe accuracy to some degree).

Afternote: For those interested in viewing auroras on a specific day, a recommended method is to generate a max pixel value map for that particular date. To provide context and account for potential gaps in satellite coverage, it would be helpful to include a mean pixel value map for the full month beneath it. This approach compensates for the patchiness seen in this dataset.

![Day 13](Day%2013/Day%2013_June2025_v2.png)

Data Source: [VNP46A2: VIIRS Lunar Gap-Filled BRDF Nighttime Lights Daily L3 Global 500m](https://developers.google.com/earth-engine/datasets/catalog/NASA_VIIRS_002_VNP46A2)

### Day 12: Map from 2125

When I saw today’s theme, two thoughts came to mind. Firstly: What might maps look like in the year 2125? While traditional cartographic forms may still exist, I imagine future maps will be far more dynamic, integrated with real-time data and functioning as digital twins of the environments they represent. Secondly: I envision cities in 2125 developing a dynamic urban airspace, an ever-evolving layer of low-altitude traffic where drones operate for logistics, emergency response, and surveillance.

For this challenge, I repurposed scripts from a previous project to build a functional drone delivery viewer. In the simulation, drones launch from trucks, navigate to delivery points, descend to delivery points (marked by a red box), and return to their base vehicles. It is a simple prototype, especially given the limited time. The system tracks both the number of active drones and completed deliveries in real time.

I wish I had more time to expand the model as I wanted to introduce multiple drone types with distinct behaviors and experiment with alternative pathfinding algorithms. I am particularly interested in designing flight corridors for urban environments and exploring how agent-based systems could help shape the future of low-altitude airspace. If you have access to drone delivery datasets or are interested in collaborating on future simulations, I would love to connect.

You can try out the simulation [here](https://deliverydroneunity.netlify.app/) (note: it may take a moment to load, and it is quite basic)

![Day 12](Day%2012/Day%2012.gif)

Model sources: [3D city](https://sketchfab.com/3d-models/full-gameready-city-buildings-0545317292c44490af5408cb58633121) ; [Drone](https://assetstore.unity.com/packages/3d/vehicles/air/realistic-drone-66698) ; [Van](https://assetstore.unity.com/packages/3d/vehicles/land/low-poly-vehicle-pack-lite-217344)

### Day 11: Minimal Maps

Today's theme leans towards simplicity and the HydroSHEDS datasets are a perfect fit. By colouring the rivers according to Classical Stream Order, the map reveals the source of each river system. The result is a minimal yet striking visualisation that traces the outline of the continent while almost resembling the pulsing heart of the land itself. The theme is also a good reminder than sparse data or focusing on not overcrowding the map can create rich geographic stories.

![Day 11](Day%2011/Day%2011_SA.png)

Data Source: [HydroSHEDS](https://lnkd.in/em4Thd4P)

### Day 10: Air

I have been seeing so many mesmerizing wind and wave flow visualisations popping up on LinkedIn lately, so I decided to create one myself for today's theme. I used ERA5 monthly averaged wind data to generate a GIF that captures how wind patterns evolve throughout the year.

Each frame represents one month, using the Monthly Averaged Reanalysis dataset (i.e. the timestamps reflect months only, not specific dates or times). I am really pleased with how the results turned out. The visualisation beautifully highlights global wind circulation, and I aimed for a color palette reminiscent of Van Gogh’s Starry Night to give it a dreamy feel.

![Day 10](Day%2010/Day%2010.gif)

Data Source: [ERA5 monthly averaged data on single levels from 1940 to present](https://cds.climate.copernicus.eu/datasets/reanalysis-era5-single-levels-monthly-means?tab=overview)

### Day 9: Analog

Grateful for the occasional easy theme day so I can dedicate more time on more complex maps in the upcoming days. I couldn’t settle on one idea, so I explored a couple of analog approaches. \
🗺️ First up: a hand-drawn map where I reimagined GIS concepts and memes as geographic features. Think Null Island, Legend Lookout, Graveyard of .dbf, .shx, .prj (i.e. forgotten components of a Shapefile) and Digital Twin (Towers). \
🧲 Second: a map made from refrigerator magnets (although with some geographical inaccuracies on the placement). The left half generally features magnets from America while the right half from Europe from my time abroad. \
🏖️ Bonus idea I considered: heading to the beach to sculpt maps out of sand. Maybe next year!

![Day 9](Day%209/Day%209a.jpg)

![Day 9](Day%209/Day%209b.jpg)

### Day 8: Urban

Today's theme of urban coincides with World Urbanism Day. For this task, I explored how different buildings in Orchard (Singapore’s iconic shopping belt) are connected underground. Given our hot and humid climate, these subterranean linkways aren’t just convenient, they are essential.

Creating this map made me reflect on how little attention we give to the underground when mapping cities. It was difficult to find comprehensive datasets that include basement levels, depth information, or underground connections. This map took extra time to piece together, as I had to comb through street directories and individual building floor plans to trace where these linkways exist and at which floors.

There are several reasons why high-quality subterranean data is becoming increasingly important. As cities grow denser, we are building downward and land use planning must account for multiple depth layers. These underground connections also open up possibilities for 3D network analysis, helping us better understand accessibility and pedestrian flow beneath the surface.

![Day 8](Day%208/Day%208_edited.png)

Data Source:[Street Directory](https://www.streetdirectory.com/) ; [MRT Stations](https://data.gov.sg/datasets/d_8d886e3a83934d7447acdf5bc6959999/view) 

### Day 7: Accessibility

What makes Greggs so popular? Is it the irresistibly delicious sausage rolls and the wide assortment of baked goods? The wallet-friendly prices compared to other options? Or perhaps how incredibly accessible Greggs is across the UK.

It has been a while since I dived into urban spatial science so this was a treat for me. Using network data from OpenStreetMap and the Cityseer library, I computed accessibility scores for Greggs locations. If you are near Liverpool Street or Leicester Square, there are numerous stores within a 1km network distance. Beyond raw store counts, I also calculated proximity-weighted scores, which highlighted areas like Kings Cross St Pancras where stores are tightly clustered together.

This post is not sponsored by Greggs — but I wouldn’t say no to a box of sausage rolls delivered to Singapore.

![Day 7](Day%207/Day%207_new.png)

Data Source: [Greggs Store](https://www.allinlondon.co.uk/directory/store-finders/757-greggs?page=1)

Useful References: [Cityseer Documentation](https://cityseer.benchmarkurbanism.com/intro) ; [Computing Accessibilities](https://norman-foster-institute.github.io/ua_part1/themes/3_access/amenities.html)

### Day 6: Dimensions

To tackle this prompt, I chose to emphasise the temporal dimension rather than relying on a static 3D map. I extracted Landsat satellite imagery of the Ucayali River in Peru from 1984 to 2021, applying both natural color and terrain color composites to enhance the visualisation of river changes over time. To complement this, I incorporated the JRC Yearly Water Classification History dataset, offering an additional perspective on hydrological dynamics.

The final timelapse covers the period from 1984 to 2021, aligning with the latest available data from the JRC dataset. Certain years were excluded due to excessive cloud cover or unresolved scan line errors in the Landsat imagery. After processing the usable frames, I compiled the individual GIFs into a collage to present the Ucayali river's evolution (I think if more images in the future or other areas are chosen, an oxbow lake formation can be captured).

![Day 6](Day%206/Day%206.gif)

Data Source: [JRC Yearly Water Classification History, v1.4](https://developers.google.com/earth-engine/datasets/catalog/JRC_GSW1_4_YearlyHistory); Landsat 5, 7, 8, 9

Tutorial Source: [Time series on Landsat data with Google Earth Engine](https://www.acgeospatial.co.uk/time-series-on-landsat-data-gee/) ; [Visualizing changing landscapes with Google Earth Engine](https://medium.com/google-earth/visualizing-changing-landscapes-with-google-earth-engine-b2d502dc02a8)

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
