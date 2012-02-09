//--------------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2012 , FeiDu TECH, Ltd.
//--------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using wojilu;
using wojilu.ORM;

namespace OMS.Core.DoMain
{

 /// <summary>
 /// WarehouseType
 /// �ֿ��
 ///
 /// �޸ļ�¼
 ///
 ///		2012-02-02 �汾��1.0 XD ����������
 ///
 /// �汾��1.0
 ///
 /// <author>
 ///		<name>XD</name>
 ///		<date>2012-02-02</date>
 /// </author>
 /// </summary>
 [Table( "Warehouses" )]
 [Serializable]
 public class WarehouseType: ObjectBase<WarehouseType> 
 {

      ///<summary>
      /// ������ʶ
      ///</summary>
  //public int Id { get; set; }

      ///<summary>
      /// �ֿ�����
      ///</summary>
  public String WarehouseName { get; set; }

      ///<summary>
      /// ���ڹ���
      ///</summary>
  public String Country { get; set; }

      ///<summary>
      /// ����ʡ
      ///</summary>
  public String Province { get; set; }

      ///<summary>
      /// ������
      ///</summary>
  public String City { get; set; }
  }
}