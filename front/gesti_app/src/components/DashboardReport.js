import React from 'react'
import { Link } from 'react-router-dom';
import logo from '../images/Logo-GA.png'
import DashboardHeader from './DashboardHeader copy';
import LayoutsSidebar from './LayoutsSidebar';
import PageFooter from './PageFooter';

function DashboardReport() {
    return (
        <table class="table">
            <thead>
                <tr>
                    <th class="">Movimiento</th>
                    <th class="">Monto</th>
                    <th class="">Fecha</th>
                    <th class=""></th>
                </tr>
            </thead>
            <tbody class="bg-white">
                <tr class="align-items-center">
                    <td>
                        <div>
                            <div>
                                <img class="rounded-circle" src="https://cdn4.iconfinder.com/data/icons/taxes-11/110/vab1_3_green_dollar_coins_isometric_cartoon_cash_money-512.png" alt="" style={{ width: "50px" }} />
                            </div>
                            <div class="">
                                <strong class="">TRANSFERENCIA</strong>
                                <div class="text-sm leading-5 text-gray-500">De: Jose Lopez</div>
                            </div>
                        </div>
                    </td>

                    <td class="px-6 py-4 whitespace-no-wrap border-b border-gray-200">
                        <div class="text-sm leading-5 text-gray-900">+ $3000</div>
                    </td>

                    <td class="px-6 py-4 whitespace-no-wrap border-b border-gray-200">
                        <span class="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">20/11/2022</span>
                    </td>
                    <td>
                        Edit
                    </td>
                </tr>
                <tr>
                    <td class="px-6 py-4 whitespace-no-wrap border-b border-gray-200">
                        <div class="flex items-center">
                            <div class="flex-shrink-0 h-10 w-10">
                                <img class="rounded-circle" src="https://cdn4.iconfinder.com/data/icons/taxes-11/110/vab1_3_green_dollar_coins_isometric_cartoon_cash_money-512.png" alt="" style={{ width: "50px" }} />
                            </div>

                            <div class="ml-4">
                                <strong class="">TRANSFERENCIA</strong>
                                <div class="text-sm leading-5 text-gray-500">De: Jose Lopez</div>
                            </div>
                        </div>
                    </td>

                    <td class="px-6 py-4 whitespace-no-wrap border-b border-gray-200">
                        <div class="text-sm leading-5 text-gray-900">+ $3000</div>
                    </td>

                    <td class="px-6 py-4 whitespace-no-wrap border-b border-gray-200">
                        <span class="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">20/11/2022</span>
                    </td>
                    <td>
                        Edit
                    </td>
                </tr>
            </tbody>
        </table>
    );
}
export default DashboardReport;


