﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Yonyou.Api.Service
{
    /// <summary>
    /// 库存管理API  57
    /// </summary>
    public class StockApi : Api
    {
        public StockApi() : base("api") { }


        /// <summary>
        /// 产成品入库单 获取产成品入库单列表  
        /// </summary> 
        /// <return></return>
        public object batch_get_productinlist() { return null; }
        /// <summary>
        /// 审核一张产成品入库单  
        /// </summary> 
        /// <return></return>
        public object verify_productin() { return null; }
        /// <summary>
        /// 弃审一张产成品入库单  
        /// </summary> 
        /// <return></return>
        public object unverify_productin() { return null; }
        /// <summary>
        /// 获取单个产成品入库单  
        /// </summary> 
        /// <return></return>
        public object get_productin() { return null; }
        /// <summary>
        /// 新增一张产成品入库单  
        /// </summary> 
        /// <return></return>
        public object add_productin() { return null; }
        /// <summary>
        /// 其他入库单   批量获取其他入库信息 
        /// </summary> 
        /// <return></return>
        public object batch_get_otherinlist() { return null; }
        /// <summary>
        /// 审核一张其他入库单   
        /// </summary> 
        /// <return></return>
        public object verify_otherin() { return null; }
        /// <summary>
        /// 弃审一张其他入库单   
        /// </summary> 
        /// <return></return>
        public object unverify_otherin() { return null; }
        /// <summary>
        /// 获取其他入库单待办任务 
        /// </summary> 
        /// <return></return>
        public object tasks_otherin() { return null; }
        /// <summary>
        /// 获取其他入库单审批进程 
        /// </summary> 
        /// <return></return>
        public object history_otherin() { return null; }
        /// <summary>
        /// 获取单个其他入库信息  
        /// </summary> 
        /// <return></return>
        public object get_otherin() { return null; }
        /// <summary>
        /// 获取其他入库单是否启用工作流  
        /// </summary> 
        /// <return></return>
        public object flowenabled_otherin() { return null; }
        /// <summary>
        /// 获取其他入库单工作流按钮是否可用状态  
        /// </summary> 
        /// <return></return>
        public object buttonstate_otherin() { return null; }
        /// <summary>
        /// 审核其他入库单（工作流） 
        /// </summary> 
        /// <return></return>
        public object audit_otherin() { return null; }
        /// <summary>
        /// 新增一张其他入库单   
        /// </summary> 
        /// <return></return>
        public object add_otherin() { return null; }
        /// <summary>
        /// 弃审其他入库单（工作流） 
        /// </summary> 
        /// <return></return>
        public object abandon_otherin() { return null; }
        /// <summary>
        /// 其他出库单   获取其他出库单列表信息 
        /// </summary> 
        /// <return></return>
        public object batch_get_otheroutlist() { return null; }
        /// <summary>
        /// 审核一张其他出库单   
        /// </summary> 
        /// <return></return>
        public object verify_otherout() { return null; }
        /// <summary>
        /// 弃审一张其他出库单   
        /// </summary> 
        /// <return></return>
        public object unverify_otherout() { return null; }
        /// <summary>
        /// 获取其他出库单待办任务 
        /// </summary> 
        /// <return></return>
        public object tasks_otherout() { return null; }
        /// <summary>
        /// 获取其他出库单审批进程 
        /// </summary> 
        /// <return></return>
        public object history_otherout() { return null; }
        /// <summary>
        /// 获取单张其他出库单   
        /// </summary> 
        /// <return></return>
        public object get_otherout() { return null; }
        /// <summary>
        /// 获取其他出库单是否启用工作流  
        /// </summary> 
        /// <return></return>
        public object flowenabled_otherout() { return null; }
        /// <summary>
        /// 获取其他出库单工作流按钮是否可用状态  
        /// </summary> 
        /// <return></return>
        public object buttonstate_otherout() { return null; }
        /// <summary>
        /// 审核其他出库单（工作流） 
        /// </summary> 
        /// <return></return>
        public object audit_otherout() { return null; }
        /// <summary>
        /// 新增一张其他出库单   
        /// </summary> 
        /// <return></return>
        public object add_otherout() { return null; }
        /// <summary>
        /// 弃审其他出库单（工作流） 
        /// </summary> 
        /// <return></return>
        public object abandon_otherout() { return null; }
        /// <summary>
        /// 库存结账状态  批量获取库存结账状态 
        /// </summary> 
        /// <return></return>
        public object batch_get_mendst() { return null; }
        /// <summary>
        /// 材料出库单   获取材料出库单列表 
        /// </summary> 
        /// <return></return>
        public object batch_get_materialoutlist() { return null; }
        /// <summary>
        /// 审核材料出库单 
        /// </summary> 
        /// <return></return>
        public object verify_materialout() { return null; }
        /// <summary>
        /// 弃审材料出库单 
        /// </summary> 
        /// <return></return>
        public object unverify_materialout() { return null; }
        /// <summary>
        /// 获取材料出库单待办任务 
        /// </summary> 
        /// <return></return>
        public object tasks_materialout() { return null; }
        /// <summary>
        /// 获取材料出库单审批进程 
        /// </summary> 
        /// <return></return>
        public object history_materialout() { return null; }
        /// <summary>
        /// 获取单个材料出库单   
        /// </summary> 
        /// <return></return>
        public object get_materialout() { return null; }
        /// <summary>
        /// 获取材料出库单是否启用工作流  
        /// </summary> 
        /// <return></return>
        public object flowenabled_materialout() { return null; }
        /// <summary>
        /// 获取材料出库单工作流按钮是否可用状态  
        /// </summary> 
        /// <return></return>
        public object buttonstate_materialout() { return null; }
        /// <summary>
        /// 审核材料出库单（工作流） 
        /// </summary> 
        /// <return></return>
        public object audit_materialout() { return null; }
        /// <summary>
        /// 材料出库单   
        /// </summary> 
        /// <return></return>
        public object add_materialout() { return null; }
        /// <summary>
        /// 弃审材料出库单（工作流） 
        /// </summary> 
        /// <return></return>
        public object abandon_materialout() { return null; }
        /// <summary>
        /// 现存量 现存量查询 
        /// </summary> 
        /// <return></return>
        public object batch_get_currentstock() { return null; }
        /// <summary>
        /// 调拨单 获取调拨单列表 
        /// </summary> 
        /// <return></return>
        public object batch_get_transvouchlist() { return null; }
        /// <summary>
        /// 审核一张调拨单 
        /// </summary> 
        /// <return></return>
        public object verify_transvouch() { return null; }
        /// <summary>
        /// 弃审一张调拨单 
        /// </summary> 
        /// <return></return>
        public object unverify_transvouch() { return null; }
        /// <summary>
        /// 获取单个调拨单 
        /// </summary> 
        /// <return></return>
        public object get_transvouch() { return null; }
        /// <summary>
        /// 添加一个新调拨单    
        /// </summary> 
        /// <return></return>
        public object add_transvouch() { return null; }
        /// <summary>
        /// 调拨申请单   获取调拨申请单列表 
        /// </summary> 
        /// <return></return>
        public object batch_get_transappvouchlist() { return null; }
        /// <summary>
        /// 获取单个调拨申请单   
        /// </summary> 
        /// <return></return>
        public object get_transappvouch() { return null; }
        /// <summary>
        /// 采购入库单   获取采购入库单列表 
        /// </summary> 
        /// <return></return>
        public object batch_get_purchaseinlist() { return null; }
        /// <summary>
        /// 审核一张采购入库单   
        /// </summary> 
        /// <return></return>
        public object verify_purchasein() { return null; }
        /// <summary>
        /// 弃审一张采购入库单   
        /// </summary> 
        /// <return></return>
        public object unverify_purchasein() { return null; }
        /// <summary>
        /// 获取单个采购入库单   
        /// </summary> 
        /// <return></return>
        public object get_purchasein() { return null; }
        /// <summary>
        /// 新增一张采购入库单   
        /// </summary> 
        /// <return></return>
        public object add_purchasein() { return null; }
        /// <summary>
        /// 销售出库单   批量获取销售出库单列表(包含子表)   
        /// </summary> 
        /// <return></return>
        public object batch_get_saleoutlistall() { return null; }
        /// <summary>
        /// 获取销售出库单列表   
        /// </summary> 
        /// <return></return>
        public object batch_get_saleoutlist() { return null; }
        /// <summary>
        /// 审核一张销售出库单   
        /// </summary> 
        /// <return></return>
        public object verify_saleout() { return null; }
        /// <summary>
        /// 弃审一张销售出库单   
        /// </summary> 
        /// <return></return>
        public object unverify_saleout() { return null; }
        /// <summary>
        /// 获取单个销售出库单   
        /// </summary> 
        /// <return></return>
        public object get_saleout() { return null; }

    }
}
