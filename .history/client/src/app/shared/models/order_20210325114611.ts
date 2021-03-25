import { IAddress } from "./address";

export interface IOrderToCreate {
    basketId: string;
    deliveryMethodId: number;
    shipToAddess: IAddress;
  }

    export interface IOrder {
        id: number;
        buyerEmail: string;
        orderDate: string;
        shipToAddress: ShipToAddress;
        deliveryMethod: string;
        shippingPrice: number;
        orderItems: OrderItem[];
        subtotal: number;
        status: string;
        total: number;
        paymentIntentId: string;
    }

  interface OrderItem {
    productId: number;
    productName: string;
    pictureUrl: string;
    price: number;
    quantity: number;
  }