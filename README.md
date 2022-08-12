# blazor.loading
A set of loading indicator components for Blazor (based on https://loading.io/)

...

## Pure css loading

![image](https://user-images.githubusercontent.com/6169846/180429761-04397ed5-fb5d-4319-9001-10d6eb025744.png)

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

![image](https://user-images.githubusercontent.com/6169846/180429866-1342c014-556d-449a-a93a-ba13963c5b68.png)

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
        background: #aaa;
    }
</style>

<div class="container">
    <div class="wrapper">
        <SunnyLoading Size="100" />
        <div style="margin-top:-25px">Loading...</div>
    </div>
    <div class="wrapper"><GiftLoading Size="100" /></div>
    <div class="wrapper"><AtomLoading Size="100" /></div>
</div>

<div class="container">
    <div class="wrapper"><BallLoading Size="100" /></div>
    <div class="wrapper"><BallsLoading Size="100" /></div>
    <div class="wrapper"><BarChartLoading Size="100" /></div>
</div>

<div class="container">
    <div class="wrapper"><FadingBarsLoading Size="100" /></div>
    <div class="wrapper"><BasketballLoading Size="100" /></div>
    <div class="wrapper"><BeanEaterLoading Size="100" /></div>
</div>

<div class="container">
    <div class="wrapper"><BlocksLoading Size="100" /></div>
    <div class="wrapper"><BlueCatLoading Size="100" /></div>
    <div class="wrapper"><BooksLoading Size="100" /></div>
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
