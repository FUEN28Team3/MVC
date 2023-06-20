[V] _Layout & Index 頁面完成
	--更改 content的css位址
	--更改 Script 的 JS位址 bootstrap位址

[V]	-- 新增Form 頁面  /Home/Index

[working on] 創建EFModels
			 --新增 各自的Controller (View Models)
			 --cshtml可以從/Home/Index 裡面的Index.cshtml 更改版型內容。
			 --在自己的Index.cshtml @{BiewBag.Title = "Index";}下面加上
					<main id="main" class="main">
                        <div class="pagetitle">
                            <h1>Form Elements</h1>
                            <nav>
                                <ol class="breadcrumb">
                                    <li class="breadcrumb-item"><a href="@Url.Action("Index","Default")">首頁</a></li>
                                    <li class="breadcrumb-item">   這裡是____管理  </li>
                                    <li class="breadcrumb-item active">  這裡是____頁面  </li>
                                </ol>
                            </nav>
                        </div>
                        <!-- End Page Title -->
                             <section class="section">
                                    這裡是頁面的內容
                             </section>
                        </main>
            -- table 部分想要調整可以加上這幾個class <table class="table table-striped table-hover">

[V] - 修改 DataTable 的模板樣式，更改成中文版本
    - 加上 FormEdit 的 View 頁面
    - 加上 _LayOutFront 前台畫面
    - 直接加上EFModels

[V] - 安裝bootstrapsMVC5套件 ( 升級 .Net Framework 4.8版本)
