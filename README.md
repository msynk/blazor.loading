# blazor.loading
A set of loading indicator components for Blazor (based on https://loading.io/)

...

## Pure css loading

![image](https://user-images.githubusercontent.com/6169846/184406437-1d54a23a-929b-45fc-9ce1-134ba23d5a40.png)


```razor
<style>
    .container {
        display: flex;
        align-items: center;
        justify-content: space-evenly;
        height: 100px;
    }
</style>

<div class="container">
    <BarsLoading Color="royalblue" Size="64" />
    <CircleLoading Color="royalblue" Size="64" />
    <DotsRingLoading Color="royalblue" Size="64" />
</div>

<div class="container">
    <DualRingLoading Color="royalblue" Size="64" />
    <EllipsisLoading Color="royalblue" Size="64" />
    <GridLoading Color="royalblue" Size="64" />
</div>

<div class="container">
    <HeartLoading Color="royalblue" Size="64" />
    <HourglassLoading Color="royalblue" Size="64" />
    <RingLoading Color="royalblue" Size="64" />
</div>

<div class="container">
    <RippleLoading Color="royalblue" Size="64" />
    <RollerLoading Color="royalblue" Size="64" />
    <SpinnerLoading Color="royalblue" Size="64" />
</div>
```

...

## Pure SVG loading

![image](https://user-images.githubusercontent.com/6169846/184406288-9791f05e-0040-49c1-aaa6-2f051494f4b0.png)


```razor
<style>
    .container {
        display: flex;
        align-items: center;
        justify-content: space-evenly;
        height: 150px;
        margin-bottom: 25px;
    }

    .wrapper {
        padding: 25px;
        text-align: center;
        background: #333;
    }
</style>

<div class="container">
    <div class="wrapper"><SunnyLoading Size="100" /></div>
    <div class="wrapper"><GiftLoading Size="100" /></div>
    <div class="wrapper"><AtomLoading Size="100" /></div>
    <div class="wrapper"><BallLoading Size="100" /></div>
    <div class="wrapper"><BallsLoading Size="100" /></div>
    <div class="wrapper"><BarChartLoading Size="100" /></div>
</div>

<div class="container">
    <div class="wrapper"><FadingBarsLoading Size="100" /></div>
    <div class="wrapper"><BasketballLoading Size="100" /></div>
    <div class="wrapper"><BeanEaterLoading Size="100" /></div>
    <div class="wrapper"><BlocksLoading Size="100" /></div>
    <div class="wrapper"><BlueCatLoading Size="100" /></div>
    <div class="wrapper"><BooksLoading Size="100" /></div>
</div>

<div class="container">
    <div class="wrapper"><BricksLoading Size="100" /></div>
    <div class="wrapper"><BubbleLoading Size="100" /></div>
    <div class="wrapper"><BucketLoading Size="100" /></div>
    <div class="wrapper"><CameraLoading Size="100" /></div>
    <div class="wrapper"><ChunkLoading Size="100" /></div>
    <div class="wrapper"><ClockLoading Size="100" /></div>
</div>
```

...

## Pure SVG Background loading

![image](https://user-images.githubusercontent.com/6169846/184405072-15cbb4db-c778-48bb-a2a0-2e5c5b7eae2f.png)

```razor
<style>
    .container {
        display: flex;
        background: #333;
        margin-bottom: 25px;
    }

    .wrapper {
        width: 100%;
        padding: 25px;
    }
</style>

<div class="container">
    <div class="wrapper"><CloudBgLoading /></div>
    <div class="wrapper"><RainBgLoading /></div>
    <div class="wrapper"><GooeyBgLoading /></div>
</div>

<div class="container">
    <div class="wrapper"><MazeBgLoading /></div>
    <div class="wrapper"><FireworksBgLoading /></div>
    <div class="wrapper"><RaindropBgLoading /></div>
</div>

<div class="container">
    <div class="wrapper"><MatrixBgLoading /></div>
    <div class="wrapper"><StripeBgLoading /></div>
    <div class="wrapper"><LinesBgLoading /></div>
</div>
```
